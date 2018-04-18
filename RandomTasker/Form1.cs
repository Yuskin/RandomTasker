using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomTasker {
    public partial class Form1 : System.Windows.Forms.Form {

        //path to file with tasks
        const string path = @".\Tasks.json";
        //sign of showing aditional part of menu
        bool slide = false;
        //Class for loading and saving tasks
        TaskMaster taskMaster;
        Random rand;


        public Form1() {
            InitializeComponent();
            rand = new Random();
            taskMaster = new TaskMaster(path);
            fillTaskListView();
        }

        //Filling listview of tasks
        private void fillTaskListView()
        {
            ListViewItem[] item = new ListViewItem[taskMaster.Tasks.Length];

            taskListView.Items.Clear();
            int i = 0;
            foreach (Task task in taskMaster.Tasks)
            {
                item[i] = new ListViewItem(task.Name);
                item[i].SubItems.Add(task.Description);
                i++;
            }
            taskListView.Items.AddRange(item);
        }

        //Show random task after click
        private void taskButton_Click(object sender, EventArgs e) {
            int randValue = rand.Next(0, taskMaster.Tasks.Length);

            taskToolTip.SetToolTip(taskButton, taskMaster.Tasks[randValue].Description.ToString());
            taskButton.Text = taskMaster.Tasks[randValue].Name.ToString();
        }

        //Show additional menu
        private void slideButton_Click(object sender, EventArgs e)
        {
            slide = !slide;
            if (slide)
            {
                slideButton.BackgroundImage = Properties.Resources.TrangleUp;
                this.Height = this.Height * 3;
            }
            else
            {
                slideButton.BackgroundImage = Properties.Resources.TrangleDown;
                this.Height = this.Height / 3;
                if (saveButton.Visible)
                    if (MessageBox.Show("Do you want save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        saveButton.PerformClick();
            }
        }

        //get properties of selected task
        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListView.SelectedIndices.Count > 0)
            {
                nameTextBox.Text = taskListView.SelectedItems[0].Text;
                detailTextBox.Text = taskListView.SelectedItems[0].SubItems[1].Text;
            }
            else editButton.Visible = false;
        }

        //Control on changing of the textboxes
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Visible = nameTextBox.Text != "";
            editButton.Visible = nameTextBox.Text != "" && taskListView.SelectedItems.Count>0;
        }

        //Add new task
        private void addButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(nameTextBox.Text);
            item.SubItems.Add(detailTextBox.Text);
            taskListView.Items.Add(item);
            defaultButton.Visible = true;
            saveButton.Visible = true;
        }

        //Edit selected task
        private void editButton_Click(object sender, EventArgs e)
        {
            taskListView.SelectedItems[0].Text = nameTextBox.Text;
            taskListView.SelectedItems[0].SubItems[1].Text = detailTextBox.Text;
            defaultButton.Visible = true;
            saveButton.Visible = true;
        }


        //Check task in the taskListView
        private void taskListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            delButton.Visible = taskListView.CheckedItems.Count > 0;
        }
        //Call procedure for deleting checked tasks
        private void delButton_Click(object sender, EventArgs e)
        {
            delTaskListViewItems();
            defaultButton.Visible = true;
            delButton.Visible = false;
            saveButton.Visible = true;
        }

        //Delete checked tasks
        private void delTaskListViewItems()
        {
            ListView.CheckedIndexCollection checkedItems = taskListView.CheckedIndices;
            while (checkedItems.Count > 0)
            {
                taskListView.Items.RemoveAt(checkedItems[0]);
            }
            editButton.Visible = nameTextBox.Text != "" && taskListView.SelectedItems.Count > 0;
        }

        //undo all changes before last saving
        private void defaultButton_Click(object sender, EventArgs e)
        {
            fillTaskListView();
            defaultButton.Visible = false;
            editButton.Visible = false;
            saveButton.Visible = false;
        }

        //save last changes
        private void saveButton_Click(object sender, EventArgs e)
        {
            Task[] newTasks = new Task[taskListView.Items.Count];
            int i = 0;
            foreach (ListViewItem item in taskListView.Items)
            {
                newTasks[i++] = new Task(item.Text, item.SubItems[1].Text);
            }
            taskMaster.SaveJSON(path, newTasks);
            defaultButton.Visible = false;
            editButton.Visible = false;
            saveButton.Visible = false;
        }
    }
}

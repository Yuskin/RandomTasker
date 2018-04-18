namespace RandomTasker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ColumnHeader Description;
            this.taskButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.slideButton = new System.Windows.Forms.Button();
            this.taskListView = new System.Windows.Forms.ListView();
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.detailLabel = new System.Windows.Forms.Label();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.taskToolTip = new System.Windows.Forms.ToolTip(this.components);
            Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskButton
            // 
            this.taskButton.BackColor = System.Drawing.Color.Transparent;
            this.taskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskButton.ForeColor = System.Drawing.Color.Green;
            this.taskButton.Location = new System.Drawing.Point(39, 67);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(270, 72);
            this.taskButton.TabIndex = 1;
            this.taskButton.Text = "FIND TASK";
            this.taskToolTip.SetToolTip(this.taskButton, "Show random task");
            this.taskButton.UseVisualStyleBackColor = false;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.slideButton);
            this.panel.Controls.Add(this.taskButton);
            this.panel.Location = new System.Drawing.Point(-1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(350, 220);
            this.panel.TabIndex = 2;
            // 
            // slideButton
            // 
            this.slideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slideButton.BackgroundImage")));
            this.slideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideButton.Location = new System.Drawing.Point(137, 163);
            this.slideButton.Name = "slideButton";
            this.slideButton.Size = new System.Drawing.Size(75, 40);
            this.slideButton.TabIndex = 2;
            this.taskToolTip.SetToolTip(this.slideButton, "Show tasks list");
            this.slideButton.UseVisualStyleBackColor = true;
            this.slideButton.Click += new System.EventHandler(this.slideButton_Click);
            // 
            // taskListView
            // 
            this.taskListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.taskListView.AutoArrange = false;
            this.taskListView.CheckBoxes = true;
            this.taskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task,
            Description});
            this.taskListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.taskListView.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.taskListView.ForeColor = System.Drawing.Color.Green;
            this.taskListView.GridLines = true;
            this.taskListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.taskListView.HideSelection = false;
            this.taskListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.taskListView.Location = new System.Drawing.Point(12, 226);
            this.taskListView.MultiSelect = false;
            this.taskListView.Name = "taskListView";
            this.taskListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskListView.ShowItemToolTips = true;
            this.taskListView.Size = new System.Drawing.Size(320, 335);
            this.taskListView.TabIndex = 3;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.List;
            this.taskListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.taskListView_ItemChecked);
            this.taskListView.SelectedIndexChanged += new System.EventHandler(this.taskListView_SelectedIndexChanged);
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 320;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 50;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.nameLabel.Location = new System.Drawing.Point(8, 573);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Task:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Green;
            this.nameTextBox.Location = new System.Drawing.Point(49, 570);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(283, 26);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.detailLabel.Location = new System.Drawing.Point(8, 597);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(88, 19);
            this.detailLabel.TabIndex = 6;
            this.detailLabel.Text = "Description:";
            // 
            // detailTextBox
            // 
            this.detailTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.detailTextBox.ForeColor = System.Drawing.Color.Green;
            this.detailTextBox.Location = new System.Drawing.Point(12, 614);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(320, 43);
            this.detailTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(292, 663);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 8;
            this.taskToolTip.SetToolTip(this.addButton, "Add new task");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delButton.BackgroundImage")));
            this.delButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.Location = new System.Drawing.Point(12, 663);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(40, 40);
            this.delButton.TabIndex = 9;
            this.taskToolTip.SetToolTip(this.delButton, "Delete selected tasks");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Location = new System.Drawing.Point(246, 663);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 10;
            this.taskToolTip.SetToolTip(this.editButton, "Edit current task");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(154, 663);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(40, 40);
            this.saveButton.TabIndex = 11;
            this.taskToolTip.SetToolTip(this.saveButton, "Save all changes");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("defaultButton.BackgroundImage")));
            this.defaultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.defaultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defaultButton.Location = new System.Drawing.Point(108, 663);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(40, 40);
            this.defaultButton.TabIndex = 12;
            this.taskToolTip.SetToolTip(this.defaultButton, "Undo all changes");
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Visible = false;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // taskToolTip
            // 
            this.taskToolTip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.taskToolTip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taskToolTip.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 212);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.detailTextBox);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RandomTasker";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button slideButton;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.ToolTip taskToolTip;
    }
}


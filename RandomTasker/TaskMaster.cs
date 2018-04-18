using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace RandomTasker
{
    class TaskMaster
    {   
        //array with tasks
        public Task[] Tasks { get; set; }

        public TaskMaster(string path)
        {
            string file;
            try
            {
                file = File.ReadAllText(path);
                Tasks = JsonConvert.DeserializeObject<Task[]>(file);
            }
            catch
            {
                file = "";
                CreateJSON(path);
                file = File.ReadAllText(path);
            }
            

        }

        //Creating new file with default tasks
        public void CreateJSON(string path)
        {
            Tasks = new Task[9];
            Tasks[0] = new Task("Make a call", "Call to relatives or friends");
            Tasks[1] = new Task("Take a walk", "Visit some places or just go for a walk on the streets");
            Tasks[2] = new Task("Read a book", "There is a lot of interesting books");
            Tasks[3] = new Task("Do sports", "Go to the Gym, go to play football or do something else");
            Tasks[4] = new Task("Watch TV", "Probably something interesting is showing on TV now");
            Tasks[5] = new Task("Create new app", "It is time for coding!");
            Tasks[6] = new Task("Clean up", "It is very impotant to keep your room tidy and clean up after yourself");
            Tasks[7] = new Task("Go eat", "Go to the nearest cafe or cook something tasty at home");
            Tasks[8] = new Task("Edit your tasklist", "Add, delete or edit some tasks");
            string serialized = JsonConvert.SerializeObject(Tasks);
            File.WriteAllText(path, serialized, Encoding.Unicode);
        }

        //Save new tasks to file
        public void SaveJSON(string path, Task[] newTasks = null)
        {
            if (newTasks != null) Tasks = newTasks;
            string serialized = JsonConvert.SerializeObject(Tasks);
            File.WriteAllText(path, serialized, Encoding.Unicode);
        }
    }

    class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class Tasks
{
    private ITask task;
    public Tasks() 
    {
        task = new Draft();
    }
    public void StartTask()
    {
        while (true)
        {
            task.StartTask();
            Thread.Sleep(5000);
            task.ChangeTask(this);
        }
    }
    public void SetTask(ITask task)
    {
        this.task = task;
    }
    public ITask GetTask()
    {
        return task;
    }
}


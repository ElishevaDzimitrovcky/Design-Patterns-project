using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class Staged : ITask
{
    public string GetTask()
    {
        return "stage task";
    }
    public void StartTask()
    {
        Console.WriteLine("start stage task");
    }

    public void ChangeTask(ITask task)
    {
        task = new Commited();
    }

    public string StagedTask()
    {
        return "this is a staged task";
    }
}

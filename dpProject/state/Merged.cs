using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class Merged : ITask
{
    public string GetTask()
    {
        return "merge task";
    }
    public void StartTask()
    {
        Console.WriteLine("start merge task");
    }

    public void ChangeTask(ITask task)
    {
        task = new Staged();
    }

    public string MergedTask()
    {
        return "this is a merge task";
    }
}

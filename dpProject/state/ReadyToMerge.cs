using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class ReadyToMerge : ITask
{
    public string GetTask()
    {
        return "ready to merge task";
    }
    public void StartTask()
    {
        Console.WriteLine("start ready to merge task");
    }

    public void ChangeTask(ITask task)
    {
        task = new Merged();
    }

    public string ReadyToMergeTask()
    {
        return "this is a ready to merge task";
    }
}

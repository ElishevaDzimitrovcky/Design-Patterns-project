using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class Draft : ITask
{
    public string GetTask()
    {
        return "draft task";
    }
    public void StartTask()
    {
        Console.WriteLine("start draft task");
    }

    public void ChangeTask(Tasks task)
    {
        task.SetTask(new Staged());
    }

    public string DraftTask()
    {
        return "this is a draft task";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class Commited : ITask
{
    public string GetTask()
    {
        return "commit task";
    }
    public void StartTask()
    {
        Console.WriteLine("start commit task");
    }

    public void ChangeTask(ITask task)
    {
        task = new UnderReview();
    }

    public string CommitedTask()
    {
        return "this is a commit task";
    }
}

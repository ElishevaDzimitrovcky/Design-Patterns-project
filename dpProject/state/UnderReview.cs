using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public class UnderReview : ITask
{
    public string GetTask()
    {
        return "under review task";
    }
    public void StartTask()
    {
        Console.WriteLine("start under review task");
    }

    public void ChangeTask(Tasks task)
    {
        task.SetTask(new ReadyToMerge());
    }

    public string UnderReviewTask()
    {
        return "this is a under review task";
    }
}

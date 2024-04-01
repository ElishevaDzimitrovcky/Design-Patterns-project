using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.state;

public interface ITask
{
    public string GetTask();
    public void StartTask();
    public void ChangeTask(ITask task);

}

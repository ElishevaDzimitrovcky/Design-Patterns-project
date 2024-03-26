using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Memento;

public class CurrentMemento : IMemento
{
    private string state;
    public CurrentMemento(string state)
    {
        this.state = state;
    }
    public string GetBranchName()
    {
        return $"{state.Substring(0, 9)}";
    }

    public string GetBranchState()
    {
       return state;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Memento;

public class Originator
{
    private string state;
    public Originator(string state)
    {
        this.state = state;
    }
    public IMemento Save()
    {
        return new CurrentMemento(state);
    }

}

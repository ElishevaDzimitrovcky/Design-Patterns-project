using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Memento;

public interface IMemento
{
    string GetBranchName();
    string GetBranchState();
}

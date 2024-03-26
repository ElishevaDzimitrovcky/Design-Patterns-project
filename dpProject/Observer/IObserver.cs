using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Observer;

public interface IObserver
{
    public void Update(IState state);
}

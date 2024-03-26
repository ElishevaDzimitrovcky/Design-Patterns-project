using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Prototype;

public class CreateBranch : Cloneable
{
    public override void Clone(string n)
    {
        new Branch(n);
    }
}

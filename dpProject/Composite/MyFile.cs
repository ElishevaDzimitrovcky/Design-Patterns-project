using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Composite;

public class MyFile : Item
{
    public string Name { get; set; }

    public override string Type()
    {
        return "file";
    }
}

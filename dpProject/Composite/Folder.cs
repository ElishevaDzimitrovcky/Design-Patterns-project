using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject;

public class Folder : Item
{
    private List<Item> items = new List<Item>();
    public void add(Item item)
    {
        items.Add(item);
    }
    public override string Type()
    {
        return "folder";
    }
}

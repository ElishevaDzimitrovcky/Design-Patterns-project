using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpProject.Composite;

namespace dpProject;
public class Branch
{
    public string Name { get; set; }
    List<Item> items { get; set; }
    public Branch(string name)
    {
        Name = name;
    }
    public void Add(Item item)
    {
        items.Add(item);
    }
    public string Merge()
    {
        return "you merged the branches.";
    }
    public string Commit()
    {
        return "you commited.";
    }
    public string Delete()
    {
        return "you deleted a branch.";
    }
    public string Create()
    {
        return "you created a branch.";
    }
    public string Undo()
    {
        return "undo the commit.";
    }
    public string Review()
    {
        return "request a review.";
    }
}

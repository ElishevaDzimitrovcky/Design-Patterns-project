using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject.Memento;

public class Caretaker
{
    private List<IMemento> mementoList = new List<IMemento>();
    private Originator origininator = null;
    public Caretaker(Originator originator)
    {
        this.origininator = originator;
    }
    public void Backup()
    {
        Console.WriteLine("Saving Originator's state.");
        this.mementoList.Add(this.origininator.Save());
    }
    public void Undo()
    {
        if(mementoList.Count == 0) return;
        var memento = mementoList.Last();
        mementoList.Remove(memento);
    }
    public void History()
    {
        Console.WriteLine("List of mementos: ");
        foreach(var memento in mementoList)
        {
            Console.WriteLine(memento.GetBranchName());
        }
    }
}

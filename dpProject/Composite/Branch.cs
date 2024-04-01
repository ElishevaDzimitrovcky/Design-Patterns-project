using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpProject.Composite;
using dpProject.Observer;
using dpProject.state;

namespace dpProject;
public class Branch :Item , IState
{
    public string Name { get; set; }
    public ITask State { get; set; } = new Draft();
    List<Item> items { get; set; }

    List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        Console.WriteLine("Attached an observer.");
        _observers.Add(observer);
    }
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Detached an observer.");
    }
    public void Notify()
    {
        Console.WriteLine("Notifying observers...");
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
    public Branch(string name)
    {
        Name = name;
    }
    public Branch()
    {
        
    }
    public void Add(Item item)
    {
        items?.Add(item);
    }
    public string Merge()
    {
        return "you merged the branches.";
    }
    public string Commit()
    {
        if(State.GetType() != typeof(Staged))
        {
            return "Can't commit, try to run 'commit'";
        }
        State.ChangeTask(State);
        return "you commited.";
    }
    public string Delete(Item item)
    {
        items.Remove(item);
        return "you deleted a branch.";
    }
    public string Create()
    {
        Console.WriteLine("Enter a branch name:");
        string name = Console.ReadLine();
        items.Add(new Branch(name));
        return "you created a branch.";
    }
    public string Undo()
    {
        return "undo the commit.";
    }
    public string Review()
    {
        Notify();
        return "request a review.";
    }

    public override string Type()
    {
        return "Branch";
    }
}

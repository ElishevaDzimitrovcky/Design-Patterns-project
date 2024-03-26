using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpProject.Composite;
using dpProject.Observer;

namespace dpProject;
public class Branch : IState
{
    public string Name { get; set; }
    List<Disk> disks { get; set; }
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
    public void Add(Disk disk)
    {
        disks.Add(disk);
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
        this.Notify();
        return "request a review.";

    }
   
}

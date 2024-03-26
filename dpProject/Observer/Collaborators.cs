using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace dpProject.Observer;

public class Collaborators : IObserver
{
    public void Update(IState state)
    {
        Console.WriteLine("Are you a collaborator? y/n");
        string ans = Console.ReadLine();
        if (ans == "y")
        {
            Console.WriteLine("good luck!");
        }
        else
        {
            Console.WriteLine("you have no access to the brunch.");
        }
    }
}

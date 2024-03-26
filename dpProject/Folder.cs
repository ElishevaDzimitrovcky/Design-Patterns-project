using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpProject;

public class Folder : Disk
{
    private List<Disk> disks = new List<Disk>();
    public void add(Disk disk)
    {
        disks.Add(disk);
    }
    public override int Size()
    {
    }
}

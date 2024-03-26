using dpProject;
using dpProject.Observer;
using dpProject.state;

var branch = new Branch();
var o1 = new Collaborators();
o1.Update(branch);
branch.Attach(o1);


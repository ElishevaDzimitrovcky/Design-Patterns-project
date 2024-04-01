
using dpProject;
using dpProject.Composite;
using dpProject.Memento;
using dpProject.Observer;
using dpProject.Prototype;
using dpProject.state;

var mainBranch = new Branch("main");
var serverBranch = new Branch("server");
var clientBranch = new Branch("client");
var DBBranch = new Branch("DB");
mainBranch.Add(serverBranch);
mainBranch.Add(clientBranch);
mainBranch.Add(DBBranch);

var packeges = new Folder();
var dependencies = new Folder();
var program = new MyFile();
clientBranch.Add(packeges);
clientBranch.Add(dependencies);
clientBranch.Add(program);


var src = new Folder();
var nodeModels = new Folder();
var packegeJson = new MyFile();
clientBranch.Add(src);
clientBranch.Add(nodeModels);
clientBranch.Add(packegeJson);



var dbMDF = new MyFile();
DBBranch.Add(dbMDF);

var admin = new Collaborators();
var superviser = new Collaborators();

mainBranch.Attach(admin);
mainBranch.Attach(superviser);

mainBranch.Notify();

serverBranch.State = new Staged();
serverBranch.Commit();
clientBranch.Merge();

var create = new CreateBranch();
create.Clone("clientBranch");

var originator = new Originator("Commit");
var originator1 = new Originator("Merge");
var caretaker = new Caretaker(originator);
var caretaker1 = new Caretaker(originator1);
caretaker.Backup();
caretaker1.Backup();
caretaker.History();
caretaker.Undo();
caretaker.History();


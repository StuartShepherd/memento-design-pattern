using MomentoDesignPattern;
using System;

Console.WriteLine("Momento Design Pattern");
Console.WriteLine("Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.");
Console.WriteLine();

var originator = new Originator("Alpha");
var caretaker = new Caretaker(originator);
caretaker.Save();

originator.ChangeState("Beta");
caretaker.Save();

originator.ChangeState("Gamma");
caretaker.Save();

originator.ChangeState("Delta");

caretaker.ShowHistory();

caretaker.Undo();
caretaker.Undo();
caretaker.Undo();

Console.WriteLine();
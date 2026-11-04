using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}


/*-----------------------------------------------------------------------------------------------------------------------------------

When using C# in Visual Studio, you will normally have to use Console App as the template. Normally, ppl would choose

Console App (.NET Core), but its been replaced by simply Console App and hence it will be a bit different. For starters, this code

doesnt get automatically created for you in Porgram class when making a project using this template, so you would have

to write this manually yourself.



Now, lets dive into what each line does and what it means.



1.using System means that we can use classes from the System namespace. Basically, a toolbox with access to tools.


2.Second row is simply blank. Having blank rows allows for code to be easily read, bcs having everything stacked right on top of eachother, especially if its a huge

huge application we are talking about, makes it a nightmare to follow and understand.



3.namespace is used to organize your code, and it is a container for classes and other namespaces. Namespace is usually named after

the name of the project, this is done because some applications have multiple project instances in them and they are all named differently,

but say if both of them contain files that are the same names, thats where having namespaces that match the name of the project instances

comes in handy, so that it doesnt create both confusion as well as unwanted conflicts.


3.The curly braces {} are the start and finish of a block of code.

4.
-------------------------------------------------------------------------------------------------------------------------------------*/

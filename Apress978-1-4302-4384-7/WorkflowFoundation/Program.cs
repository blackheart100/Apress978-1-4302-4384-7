using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowFoundation
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new ForEachAct();
            WorkflowInvoker.Invoke(workflow1);
            Console.ReadKey();
        }
    }
}

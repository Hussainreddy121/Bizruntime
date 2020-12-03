using System;


namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatewithNonstatic dn = new DelegatewithNonstatic();
            customer cr = new customer(dn.delegatewithNonstatic);
            cr("hello");

            add a = DelegateWithStatic.delegatewithstatic;
            a(10, 20);

            EventProgram eventProgram = new EventProgram();

            eventProgram.ProcessCompleted += EventProgram.bl_ProcessCompleted;

            eventProgram.Startprocess();

            AnonymousEx.anonymousmethod();
            
        }
    }
}

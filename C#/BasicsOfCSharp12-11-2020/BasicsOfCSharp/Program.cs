using System;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringProgram sp = new StringProgram();
            sp.stringBasic();
            sp.stringmethods();

            GenericProfram<int> gP = new GenericProfram<int>(10);
            gP.genericMethod();

            DelegationProgram dp = new DelegationProgram();
            adddelegate ad = new adddelegate(dp.add);
            ad(20);

        }
    }
}

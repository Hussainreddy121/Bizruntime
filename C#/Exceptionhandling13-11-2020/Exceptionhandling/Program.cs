using System;

namespace Exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicException.exceptionmethod();

            finallyblock.finallymethod();

            CustomeException ce = new CustomeException();
            ce.custommethod(12);

            Trycatchfinallyblocks.blocksmethod();
        }
    }
}

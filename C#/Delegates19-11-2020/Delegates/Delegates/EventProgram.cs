using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class EventProgram
    {
        public event EventHandler ProcessCompleted;

        public void Startprocess()
        {
            Console.WriteLine("process started");
            OnprocessCompleted(EventArgs.Empty);
        }

        protected virtual void OnprocessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

         // event handler
    public static void bl_ProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed!");
    }

    }
}

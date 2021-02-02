using System.Threading;

namespace TestAvaloniaBinding
{
    public class Logic
    {
        //instanciate Variable
        public Variable variable = new Variable();
        //
        public void Main()
        {
            variable.State = 0;
            variable.Pulse = 0;
            
            //this while is used to get a code that work indefinitely up to down
            while (true)
            {
                variable.State++;

                if (variable.Pulse == 0)
                {
                    variable.Pulse = 1;
                }
                else
                {
                    variable.Pulse = 0;
                }


                Thread.Sleep(100);
            }
        }

        //each variable used in Logic.cs is declared here
        public class Variable
        {
            public int State { get; set; }
            public int Pulse { get; set; }
        }
    }
}

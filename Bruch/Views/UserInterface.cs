using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruch
{
    class UserInterface
    {
        /*
         * reads an input from an user on the console
         * @return input: string
         */
        public string readInput()
        {
            string input = null;
            input = Console.ReadLine();
            return input;
        }

        /*
         * prints an output on the console
         * @param output: string
         */
        public void printOutput(string output)
        {
            Console.WriteLine(output);
        }

        /*
         * reads an Bruch input from an user on the console
         * @return input: Bruch
         */
        public Bruch readBruch()
        {
            Bruch input = null;

            return input;
        }

        /*
         * prints a Bruch output on the console
         * @param output: Bruch
         */
        public void printBruch(Bruch output)
        {
            Console.WriteLine(output);
        }
    }
}

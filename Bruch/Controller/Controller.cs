using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruch
{
    class Controller
    {
        #region attributes
        private UserInterface ui;
        #endregion

        #region constructors
        public Controller()
        {
            this.setUI(new UserInterface());
        }
        public Controller(UserInterface ui)
        {
            this.setUI(ui);
        }
        #endregion

        #region selectors
        public void setUI(UserInterface ui)
        {
            this.ui = ui;
        }
        public UserInterface getUI()
        {
            return this.ui;
        }

        public void setBrueche(List<Bruch> brueche)
        {
            this.brueche = brueche;
        }
        public List<Bruch> getBrueche()
        {
            return this.brueche;
        }
        #endregion

        #region functions
        public void run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu:\n1.\tBruch hinzufügen\n2.\tBruch löschen\n3.\tBrüche addieren\n4.\tBrüche subtrahieren\n5.\tBrüche multiplizieren\n6.\tBrüche dividieren");
                string input = ui.readInput();
                switch(input)
                {
                    case "1":
                        addBruch();
                        break;
                    case "2":
                        delBruch();
                        break;
                    case "3":
                        addieren();
                        break;
                    case "4":
                        subtrahieren();
                        break;
                    case "5":
                        multiplizieren();
                        break;
                    case "6":
                        dividieren();
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Eingabe ungültig. Versuche es nochmal.");
                        break;
                }
            }
        }

        public void addBruch()
        {
            Console.WriteLine("Controller: addBruch()");
        }

        public void delBruch()
        {
            Console.WriteLine("Controller: delBruch()");
        }
        public void addieren()
        {
            Console.WriteLine("Controller: addieren()");

        }
        public void subtrahieren()
        {
            Console.WriteLine("Controller: subtrahieren()");
        }
        public void multiplizieren()
        {
            Console.WriteLine("Controller: multiplizieren()");
        }
        public void dividieren()
        {
            Console.WriteLine("Controller: dividieren()");
        }
        #endregion
    }
}

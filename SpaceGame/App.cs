using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class App
    {

        Space[] spaces = new Space[8];
        Spaceship theShip;

        static void Main(string[] args)
        {
            App app = new App();
            app.BuildSpace();
            app.InitSpaceship();
            app.RenderSpace();
            app.ReadCommand();
            app.SayGoodbye();

            //Console.ReadKey();

        }

        void BuildSpace()
        {
            spaces[0] = new Space("SP0");
            spaces[1] = new Space("SP1");
            spaces[2] = new Space("SP2");
            spaces[3] = new Space("SP3");
            spaces[4] = new Space("SP4");
            spaces[5] = new Space("SP5");
            spaces[6] = new Space("SP6");
            spaces[7] = new Space("SP7");

            spaces[0].SpaceW = null;
            spaces[0].SpaceE = spaces[1];

            spaces[1].SpaceW = spaces[0];
            spaces[1].SpaceE = spaces[2];

            spaces[2].SpaceW = spaces[1];
            spaces[2].SpaceE = spaces[3];

            spaces[3].SpaceW = spaces[2];
            spaces[3].SpaceE = spaces[4];

            spaces[4].SpaceW = spaces[3];
            spaces[4].SpaceE = spaces[5];

            spaces[5].SpaceW = spaces[4];
            spaces[5].SpaceE = spaces[6];

            spaces[6].SpaceW = spaces[5];
            spaces[6].SpaceE = spaces[7];

            spaces[7].SpaceW = spaces[6];
            spaces[7].SpaceE = null;


        }

        void InitSpaceship()
        {
            theShip = new Spaceship("Spaceship_0");
            theShip.CurrSpace = spaces[0];
            theShip.Alignment = "east";
            theShip.sign = ">>";
        }

        void RenderSpace()
        {
            Console.Clear();
            for (int i = 0; i < spaces.Length; i++)
            {
                Console.Write("[");
                if(theShip.CurrSpace == spaces[i])
                {
                    Console.Write(theShip.sign);
                }
                for(int j = 0; j < theShip.bullets.Count; j++)
                {
                    //if(theShip.bullets[j]. )
                }
                //else Console.Write(" ");
                Console.Write("]");
            }
            Console.Write("\n");
        }

        void ReadCommand()
        {

            while (true)
            {                
                Console.WriteLine("Was möchtest Du jetzt tun? > ");
                //string cmd = Convert.ToString(Console.ReadLine());

                //Bullet b = theShip?.bullets[0] ?? new Bullet("", new Space(""));

                
                ConsoleKeyInfo cmd = Console.ReadKey();

                /*
                switch( cki.Key )
                {
                    case ConsoleKey.LeftArrow:
                        break;

                }
                */


                switch (cmd.Key)
                {
                    case ConsoleKey.A:
                        theShip.Move("west");
                        RenderSpace();
                        break;
                    case ConsoleKey.D:
                        theShip.Move("east");
                        RenderSpace();
                        break;
                    case ConsoleKey.F:
                        theShip.Fire();
                        RenderSpace();
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        Console.WriteLine("Ich habe Dich nicht verstanden");
                        break;
                }
            }
        }

        void SayGoodbye()
        {
            Console.WriteLine("Tschuesss!");
        }
    }
}

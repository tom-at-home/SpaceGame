using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Spaceship
    {

        public List<Bullet> bullets = new List<Bullet>();

        public string sign = "";

        public Spaceship(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get { return name; }
        }

        private Space currSpace;
        public Space CurrSpace
        {
            get { return currSpace; }
            set { currSpace = value; }
        }

        private string alignment;

        public string Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }

        public void Fire()
        {
           this.bullets.Add(new Bullet(this.Alignment, this.CurrSpace));
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "east":
                    if(CurrSpace.SpaceE != null)
                    {
                        this.Alignment = "east";
                        this.sign = ">>";
                        this.CurrSpace = CurrSpace.SpaceE;
                    }
                    else
                    {
                        Console.WriteLine("Dort gibt es nichts zu sehen");
                    }             
                    break;
                case "west":
                    if (CurrSpace.SpaceW != null)
                    {
                        this.Alignment = "west";
                        this.sign = "<<";
                        this.CurrSpace = CurrSpace.SpaceW;
                    }                
                    else
                    {
                        Console.WriteLine("Dort gibt es nichts zu sehen");
                    }
                    break;
            }           
        }


    }
}

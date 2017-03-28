using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Bullet
    {

        string direction;
        Space currPos;      

        public Bullet(string direction, Space startPos)
        {
            this.direction = direction;
            if(this.direction == "west")
            {
                this.currPos = startPos.SpaceW;
            }
            else if(this.direction == "east")
            {
                this.currPos = startPos.SpaceE;
            }



        }
        char sign = '-';

        private Space currSpace;
        public Space CurrSpace
        {
            get { return currSpace; }
            set { currSpace = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Space
    {
        public Space(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Space spaceW;
        public Space SpaceW
        {
            get { return spaceW; }
            set { spaceW = value; }
        }

        private Space spaceE;
        public Space SpaceE
        {
            get { return spaceE; }
            set { spaceE = value; }
        }

    }
}

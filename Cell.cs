using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class Cell
    {
        private bool state;
        public bool State
        {
            get { return state; }
            set { state = value; }
        }

        public Cell(bool state)
        {
            this.state = state;
        }
        public Cell(){
            this.state = false;
        }

    }
}

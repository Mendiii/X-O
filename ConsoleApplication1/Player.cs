using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        public string name { get; set; }
        public string sign { get; set; }

        private int _row;

        public int row
        {
            get { return _row; }
            set { _row = value; }
        }



    }
}

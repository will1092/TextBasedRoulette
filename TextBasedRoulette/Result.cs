using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRoulette
{
    class Result
    {
        private int _number;
        private string _oddity;
        private string _color;
        private string _half;
        private string _column;
        private string _dozen;

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string oddity
        {
            get { return _oddity; }
            set { _oddity = value; }
        }

        public string color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string half
        {
            get { return _half; }
            set { _half = value; }
        }

        public string column
        {
            get { return _column; }
            set { _column = value; }
        }

        public string dozen
        {
            get { return _dozen; }
            set { _dozen = value; }
        }

        public Result()
        {

        }
    }
}

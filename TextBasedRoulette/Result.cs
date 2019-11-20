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

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Oddity
        {
            get { return _oddity; }
            set { _oddity = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Half
        {
            get { return _half; }
            set { _half = value; }
        }

        public string Column
        {
            get { return _column; }
            set { _column = value; }
        }

        public string Dozen
        {
            get { return _dozen; }
            set { _dozen = value; }
        }

        public Result()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T9Spelling
{
    public class Symbol
    {
        public char Symb { get; set; }
        public int Number { get; set; }

        public Symbol()
        {
        }

        public Symbol(char symb,int number)
        {
            this.Symb = symb;
            this.Number = number;    
        }

    }
}

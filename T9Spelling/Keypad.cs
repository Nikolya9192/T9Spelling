using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections;
using System.Collections.Generic;

namespace T9Spelling
{
    class Keypad
    {
        public ArrayList listkeypad = new ArrayList();
        Symbol symbol = new Symbol();

        public Keypad()
        {
            listkeypad.Add(new Symbol('a',2));
            listkeypad.Add(new Symbol('b',22));
            listkeypad.Add(new Symbol('c',222));
            listkeypad.Add(new Symbol('d',3));
            listkeypad.Add(new Symbol('e',33));
            listkeypad.Add(new Symbol('f',333));
            listkeypad.Add(new Symbol('g',4));
            listkeypad.Add(new Symbol('h',44));
            listkeypad.Add(new Symbol('i',444));
            listkeypad.Add(new Symbol('j',5));
            listkeypad.Add(new Symbol('k',55));
            listkeypad.Add(new Symbol('l',555));
            listkeypad.Add(new Symbol('m',6));
            listkeypad.Add(new Symbol('n',66));
            listkeypad.Add(new Symbol('o',666));
            listkeypad.Add(new Symbol('p',7));
            listkeypad.Add(new Symbol('q',77));
            listkeypad.Add(new Symbol('r',777));
            listkeypad.Add(new Symbol('s',7777));
            listkeypad.Add(new Symbol('t',8));
            listkeypad.Add(new Symbol('u',88));
            listkeypad.Add(new Symbol('v',888));
            listkeypad.Add(new Symbol('w',9));
            listkeypad.Add(new Symbol('x',99));
            listkeypad.Add(new Symbol('y',999));
            listkeypad.Add(new Symbol('z',9999));
            listkeypad.Add(new Symbol(' ',0));
            
        }
        
        
    }
}

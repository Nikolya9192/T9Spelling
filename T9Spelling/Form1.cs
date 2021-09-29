using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T9Spelling
{
    public partial class Form1 : Form
    {
        public ArrayList arlOutput = new ArrayList();
        
        Symbol symbol = new Symbol();
        Keypad keypad = new Keypad();
        
       
        public int timer = 0;

        public Form1()
        {
            InitializeComponent();
            tb_message.Focus();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            timer = 0;
            
            string[] subStringArray = new string[] { };
            string[] str_razd = new string[] {"\r\n" };

            
            string str_mes = tb_message.Text.ToLower();
            
            subStringArray = str_mes.Split(str_razd, StringSplitOptions.None);
            
            arlOutput.Clear();                     
            
            Run(subStringArray);
            
            Output();

        }

   
        public void Run(string[] subStringArray)
        {
            foreach (string str in subStringArray)
            {
                Razbor(str);

            }
        }

        private void Razbor(string str)
        {
           
            timer++;
            char[] charArray = new char[] { }; 
            char[] char_razd = new char[]{};
            charArray = str.ToCharArray();

            string str_temp = String.Empty;
            string str_output = String.Empty;

            bool check;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == charArray.Length-1)
                    check = false;
                else
                    check = charArray[i].Equals(charArray[i + 1]);
                

                if (check)
                {
                    foreach (Symbol s in keypad.listkeypad)
                    {
                        if (s.Symb == charArray[i])
                            str_temp += s.Number + " ";
                    }                    
                }
                else 
                {
                    foreach (Symbol s in keypad.listkeypad)
                    {
                        if (s.Symb == charArray[i])
                            str_temp += s.Number;
                    }
                }
            }
            str_output = "Case #" + timer + "   " + str_temp;
            arlOutput.Add(str_output);
            
        }

       
        public void Output()
        {
            tb_Output.Clear(); 
            foreach (string s in arlOutput)
            {                
                tb_Output.Text += s + "\r\n";
            }
            
        }

    }
}

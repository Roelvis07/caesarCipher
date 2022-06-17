using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*string str = "abcdefghijklmnopqrstuvwxyz";
            //string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var c in str)
            {
                Console.WriteLine((int)c);
            }/**/

            //Console.WriteLine(caesarCipher("middle-Outz", 2));
            //Console.WriteLine(caesarCipher("Pz-/aI/J`EvfthGH", 66));
            Console.WriteLine(caesarCipher("Hello_World!", 4));
            
        }
        public static string caesarCipher(string s, int k)
        {
            string toReturn = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    int ascii = (int)s[i] + k;

                    if (char.IsUpper(s[i]))
                    {
                        if (ascii > 90) 
                        {
                            do
                            {
                                int aux = ascii - 90;
                                ascii = 64 + aux;

                            } while (ascii < 65 || ascii > 90);
                            
                        }
                    }
                    else
                    {
                        if (ascii > 122)
                        {
                            do
                            {
                                int aux = ascii - 122;
                                ascii = 96 + aux;

                            } while (ascii < 97 || ascii > 122);
                        }
                    }
                    toReturn += Convert.ToString((char)ascii);
                }
                else
                    toReturn += Convert.ToString(s[i]);
            }
            return toReturn;
        }
    }
}

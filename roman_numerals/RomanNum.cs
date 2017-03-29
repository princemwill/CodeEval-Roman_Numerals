using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_numerals
{    
        public class RomanNum
        {
            static void Main(string[] args)
            {
                RomanNum rom = new RomanNum();
                using (StreamReader reader = File.OpenText(args[0]))
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (null == line)
                            continue;
                        
                        Console.WriteLine(rom.ConvertToRoman(Convert.ToInt32(line)));
                    }
                Console.ReadKey();
            }

            public string ConvertToRoman(int i)
            {

                string roman = "";

                while (i >= 1000)
                {
                    roman += "M";
                    i -= 1000;
                }

                while (i >= 900)
                {
                    roman += "CM";
                    i -= 900;
                }

                while (i >= 500)
                {
                    roman += "D";
                    i -= 500;
                }

                while (i >= 400)
                {
                    roman += "CD";
                    i -= 400;
                }

                while (i >= 100)
                {
                    roman += "C";
                    i -= 100;
                }

                while (i >= 90)
                {
                    roman += "XC";
                    i -= 90;
                }

                while (i >= 50)
                {
                    roman += "L";
                    i -= 50;
                }

                while (i >= 40)
                {
                    roman += "XL";
                    i -= 40;
                }

                while (i >= 10)
                {
                    roman += "X";
                    i -= 10;
                }
                while (i >= 9)
                {
                    roman += "IX";
                    i -= 9;
                }

                while (i >= 5)
                {
                    roman += "V";
                    i -= 5;
                }

                while (i >= 4)
                {
                    roman += "IV";
                    i -= 4;
                }

                while (i >= 1)
                {
                    roman += "I";
                    i -= 1;
                }

                return roman;
            }


        }
    }

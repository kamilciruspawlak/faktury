using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Generator
    {
        public static string GenerujNumer(string maska, int numerKolejny)
        {
            string numer="";
            string rok = DateTime.Now.Year.ToString();
            string miesiac = DateTime.Now.Month.ToString();
            Dictionary<string, string> slownik = new Dictionary<string, string>();


            slownik.Add("r", rok);
            slownik.Add("n", numerKolejny.ToString());
            slownik.Add("m", miesiac);


            string[] split = maska.Split( ' ');

            for (int i=0; i < split.Length; i++ )
            {
                
                if (split[i].StartsWith("$"))
                {
                    string[] nextSplit = split[i].Split('/');
                    string tempString = "";
                    foreach (var item in nextSplit)
                    {
                        string key = item.Substring(1,1);
                        int amount = int.Parse(item.Substring(2,1));
                        string nowaWartosc = "";

                        if (slownik[key].Length - amount < 0)
                        {
                            nowaWartosc = slownik[key].PadLeft(amount, '0');
                        }
                        else
                        {
                            nowaWartosc = slownik[key].Substring(slownik[key].Length - amount, amount);
                        }
                        tempString = tempString + nowaWartosc + "/";
                    }
                    tempString = tempString.TrimEnd(new char[] { '/' });
                    split[i] = tempString;
                }
               
            }
            
        return numer = string.Join(" ", split);
        }
    }
}

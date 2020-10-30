using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            
   
            char[] nvm = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                nvm[i] = str[i];
            }
            Array.Sort(nvm);
            string b = string.Join("", nvm);

            return b;
        }
    }
}

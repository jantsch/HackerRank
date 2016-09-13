using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
       string _t = Console.ReadLine();
       int t = Int32.Parse(_t);
       for(int  i =0; i<t;i++)
       {
           string _str = Console.ReadLine();
           char[] or_str = _str.ToCharArray();
           char[] str = _str.ToCharArray();
           Array.Reverse( str );
          bool errado = false;
           for(int k = 1; k<or_str.Length;k++)
           {
               int buff = or_str[k] - or_str[k-1];
               int buff2 = str[k] - str[k-1];
                if(Math.Abs(buff) != Math.Abs(buff2))
               {
                   errado = true;
                   break;
               }
           }
           if(errado)
               Console.WriteLine("Not Funny");
           else
               Console.WriteLine("Funny");
           
       }
        
    }
}
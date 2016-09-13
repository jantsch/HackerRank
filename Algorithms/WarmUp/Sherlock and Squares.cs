using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n[0]);
            int n2 = Convert.ToInt32(tokens_n[1]);
           double result=0;
            result = Math.Floor(Math.Sqrt(n2)) - Math.Ceiling(Math.Sqrt(n1)) + 1;
            
               Console.WriteLine(result);
            
        
        }}}
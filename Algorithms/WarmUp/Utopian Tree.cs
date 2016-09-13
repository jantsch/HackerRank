using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int height = 1;
            bool x = true;
            for(int i=0;i<n;i++)
            {
                if(x)
                {height = height *2;
                x = false;
                }
                else
                {x= true;
                 height++; 
                }
            }
               Console.WriteLine(height);
            
        }
    }
}
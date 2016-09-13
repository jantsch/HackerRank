using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_d1 = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);
        int fine=0;
        
        if(y1 - y2 >= 0)
        {    if(y1 - y2>0)        
                 fine = 10000* Math.Abs(y2-y1);
             else
                if(m1-m2>=0)
                 {
                   if(m1-m2>0)
                    fine = 500* Math.Abs(m2-m1);
                   else
                    {
                       
                          if(d1-d2>0)
                            fine = 15* Math.Abs(d2-d1);
                          else
                           fine=0;
                   }
                 
                 }
                 else
                 {
                    fine =0;
                     
                 }
                 
                 
        }
        else
        {
            
            fine = 0;
            
        }
        
      
        Console.WriteLine(fine);
                    
        
        
    }
}
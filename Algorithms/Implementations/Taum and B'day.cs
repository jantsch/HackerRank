using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_b = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(tokens_b[0]);
            int w = Convert.ToInt32(tokens_b[1]);
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            decimal result = 0;
            int menor = Math.Min(x,y);
            int maior = Math.Max(x,y);
            
            
            
            if(menor + z < maior)
            {
             if(menor ==x)
                  result =  Decimal.Add(Decimal.Multiply(b,menor),Decimal.Multiply(w,(menor+z)));
              else
                  result = Decimal.Add(Decimal.Multiply(b,(menor+z)),Decimal.Multiply(w,menor));              
               
            }
            else
            {
               result = Decimal.Add(Decimal.Multiply(b,x) ,Decimal.Multiply(y,w) ) ; 
              
            }
           Console.WriteLine(result);
        }
    }
}
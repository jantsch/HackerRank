using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int pos =0;
        int neg =0;
        int zero = 0;
        
        foreach(int num in arr)
            {
            if(num >0)
                pos++;
            if(num<0)
                neg++;
            if(num==0)
                zero++;           
            
        }
           Console.WriteLine((float)pos/n);
        Console.WriteLine((float)neg/n);
        Console.WriteLine((float)zero/n);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string mystring = Console.ReadLine();
        char[] str =  mystring.ToCharArray();
        int[] result = new int[123];
        bool entrei = false;
        foreach(char let in str)
        {
            result[let]++;
                        
        }
        for(int i=97;i<=122;i++)
        {
            if(result[i]>=1)
            {
                
            }
            else
            {
                if(result[i-32]>=1)
                {
                    
                }
                else
                { 
                    entrei = true;
                    Console.WriteLine("not pangram");
                    break;
                }
                
            }
            
            
        }
        
        if(!entrei)
        Console.WriteLine("pangram");
        
        
    }
}
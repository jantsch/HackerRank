using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] grid = new string[n];
        int [,] myInt = new int[n,n];
        int [,] myInt2 = new int[n,n];
        for(int grid_i = 0; grid_i < n; grid_i++){
           grid[grid_i] = Console.ReadLine();   
           char[] myInts = grid[grid_i].ToArray();
            
           for(int i=0;i<n;i++)
           { 
             myInt[grid_i,i] =  int.Parse(myInts[i].ToString());  
              
              
           }
             
            
            
        }
        for(int k = 1; k<n-1;k++)
        {
          for(int j = 1; j<n-1;j++)
          {
              
            int mynumber = myInt[k,j];
            if(mynumber> myInt[k-1,j] && mynumber> myInt[k,j-1]  && mynumber> myInt[k+1,j]&&  mynumber> myInt[k,j+1])
             {
                myInt2[k,j] = mynumber;
               
                
             }              
          } 
        }
        
       for(int k = 0; k<n;k++)
        {
          for(int j = 0; j<n;j++)
          {
              if(myInt2[k,j] != 0)
                  Console.Write("X");
              else
                  Console.Write(myInt[k,j]);
          }
            Console.Write('\n');
       }
    }
}
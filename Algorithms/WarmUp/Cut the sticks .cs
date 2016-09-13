using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        while(arr.Length!=0)
        {
            Array.Sort<int>(arr);
            int cut = arr[0];
            List<int> termsList = new List<int>();
            int nums = 0;
            for(int k=0;k<arr.Length;k++)
            {
                arr[k] = arr[k]-cut;
                nums++;
                if(arr[k]>0)
                    termsList.Add(arr[k]);
            }
            Console.WriteLine(nums);
            arr = termsList.ToArray();
        }
        
        
    }
}
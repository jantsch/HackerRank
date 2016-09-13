using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            var Ns = Console.ReadLine();
    var N = Convert.ToInt32(Ns);
    var result = 0;
    for(int i=0; i<Ns.Length; i++)
    {
        int x = Convert.ToInt32(""+Ns[i]);
        if(x!=0 && N%x==0)
            result ++;                    
    }

    Console.WriteLine(result);

            
        }
    }
}
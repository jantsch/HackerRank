using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        DateTime dt = DateTime.Parse(time); // No error checking
        
           Console.WriteLine(dt.ToString("HH:mm:ss"));
    }
}

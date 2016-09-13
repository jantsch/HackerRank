using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
           Dictionary<int, string> number = new Dictionary<int, string>();
            number.Add(1, "one");
            number.Add(2, "two");
            number.Add(3, "three");
            number.Add(4, "four");
            number.Add(5, "five");
            number.Add(6, "six");
            number.Add(7, "seven");
            number.Add(8, "eight");
            number.Add(9, "nine");
            number.Add(10, "ten");
            number.Add(11, "eleven");
            number.Add(12, "twelve");
            number.Add(13, "thirteen");
            number.Add(14, "fourteen");
            number.Add(15, "fifteen");
            number.Add(16, "sixteen");
            number.Add(17, "seventeen");
            number.Add(18, "eighteen");
            number.Add(19, "nineteen");
            number.Add(20, "twenty");
            number.Add(21, "twenty one");
            number.Add(22, "twenty two");
            number.Add(23, "twenty three");
            number.Add(24, "twenty four");
            number.Add(25, "twenty five");
            number.Add(26, "twenty six");
            number.Add(27, "twenty seven");
            number.Add(28, "twenty eight");
            number.Add(29, "twenty nine");
            number.Add(30, "thirty");
            number.Add(31, "thirty one");
            number.Add(32, "thirty two");
            number.Add(33, "thirty three");
            number.Add(34, "thirty four");
            number.Add(35, "thirty five");
            number.Add(36, "thirty six");
            number.Add(37, "thirty seven");
            number.Add(38, "thirty eight");
            number.Add(39, "thirty nine");
            number.Add(40, "forty");
            number.Add(41, "forty one");
            number.Add(42, "forty two");
            number.Add(43, "forty three");
            number.Add(44, "forty four");
            number.Add(45, "forty five");
            number.Add(46, "forty six");
            number.Add(47, "forty seven");
            number.Add(48, "forty eight");
            number.Add(49, "forty nine");
            number.Add(50, "fifty");
            number.Add(51, "fifty");
            number.Add(52, "fifty two");
            number.Add(53, "fifty three");
            number.Add(54, "fifty four");
            number.Add(55, "fifty five");
            number.Add(56, "fifty six");
            number.Add(57, "fifty seven");
            number.Add(58, "fifty eight");
            number.Add(59, "fifty nine");
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        
          if (m < 15 && m >= 1)
            {
                if (m == 1)
                    Console.WriteLine(number[m] + " minute past " + number[h]);
                else
                {
                    Console.WriteLine(number[m] + " minutes past " + number[ h]);
                }
            }
         if (m < 30 && m >= 16)
            {
                if (m == 1)
                    Console.WriteLine(number[m] + " minute past " + number[h]);
                else
                {
                    Console.WriteLine(number[m] + " minutes past " + number[ h]);
                }
            }
        
            if (m == 30)
            {
                Console.WriteLine("half past " + number[ h]);

            }
            if (m >= 31 && m <= 44)
            {
                Console.WriteLine(number[60 - m ]+ " minutes to " + number[ h + 1]);

            }
            if (m >= 46 && m <= 59)
            {
                if(60-m ==1)
                    Console.WriteLine(number[60 - m] + " minute to " + number[ h + 1]);
                else
                Console.WriteLine(number[60 - m ]+ " minutes to " + number[ h + 1]);

            }
            if (m == 45)
            {
                Console.WriteLine("quarter to " + number[h + 1]);
            }
            if (m == 15)
            {

                Console.WriteLine("quarter past " + number[h]);
            }
            if (m == 0)
            {
                Console.WriteLine(number[h] + " o' clock");


            }
        
        
    }
}
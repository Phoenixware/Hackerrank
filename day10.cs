using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
       int remainder = 0;
        List<int> result = new List<int>();

        while (n > 0)
        {
            remainder = n % 2;
            n = n / 2;
            result.Add(remainder);
        }
        
        int counter = 0;
        int max = 0;
        var index = 0;
        result.ForEach(delegate (int r)
        {
            if (r == 1)
            {
                counter++;

                if (counter > max)
                {
                    max = counter;
                }
            }
            else
            {
                counter = 0;
            }
            index++;
        });
        
        Console.WriteLine(max);
        Console.ReadLine();
    }
}

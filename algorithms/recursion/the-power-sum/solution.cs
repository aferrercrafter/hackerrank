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

    // Complete the powerSum function below.
    static int powerSum(double X, int N, int num) {
        if(Math.Pow(num, N) > X)
            return 0;
        else if(Math.Pow(num, N) == X)
            return 1;
        
        return powerSum(X - Math.Pow(num, N), N, num + 1) + powerSum(X, N, num + 1);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int X = Convert.ToInt32(Console.ReadLine());

        int N = Convert.ToInt32(Console.ReadLine());

        int result = powerSum(X, N, 1);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

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

    // Complete the chessboardGame function below.
    static string chessboardGame(int x, int y) {
        return (x%4 == 0 || x%4 == 3 || y%4 == 0 || y%4 == 3)? "First" : "Second";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] xy = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xy[0]);

            int y = Convert.ToInt32(xy[1]);

            string result = chessboardGame(x, y);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

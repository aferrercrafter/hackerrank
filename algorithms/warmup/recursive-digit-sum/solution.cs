using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the superDigit function below.
    static int superDigit(string n, int k) {
        if(n.Length == 1)
            return int.Parse(n);    
        int sum = 0;
        int z = 0;
        for(int i = 0; i < n.Length * k; i++){
            if (z == n.Length)
                z = 0;
            sum += (int)char.GetNumericValue(n[z]);
            z++;
        }

        string dig = sum.ToString();

        return superDigit(dig, 1);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        string n = nk[0];

        int k = Convert.ToInt32(nk[1]);

        int result = superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

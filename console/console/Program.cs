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



class Data
{

    public string nama { get; set; }
    public int price { get; set; }
    public int weight { get; set; }
}
class Result
{

    /*
     * Complete the 'numDuplicates' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING_ARRAY name
     *  2. INTEGER_ARRAY price
     *  3. INTEGER_ARRAY weight
     */

    public static int numDuplicates(List<string> name, List<int> price, List<int> weight)
    {
        int hasil = 0; 
        List<Data> lst_data = new List<Data>(); 
        for (int nm = 0; nm < name.Count; nm++)
        {



        }

        return hasil; 

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int nameCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> name = new List<string>();

        for (int i = 0; i < nameCount; i++)
        {
            string nameItem = Console.ReadLine();
            name.Add(nameItem);
        }

        int priceCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> price = new List<int>();

        for (int i = 0; i < priceCount; i++)
        {
            int priceItem = Convert.ToInt32(Console.ReadLine().Trim());
            price.Add(priceItem);
        }

        int weightCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> weight = new List<int>();

        for (int i = 0; i < weightCount; i++)
        {
            int weightItem = Convert.ToInt32(Console.ReadLine().Trim());
            weight.Add(weightItem);
        }

        int result = Result.numDuplicates(name, price, weight);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

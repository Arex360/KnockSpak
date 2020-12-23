using System;
using System.Collections.Generic;
using System.Collections;
using knapsnakProblem.minWeight;
using knapsnakProblem.maxRatio;
namespace knapsnak
{
    class Program
    {
        static void Main(string[] args)
        {
           List<double> profits = new List<double>(){100,32,300,40,51};
           List<double> weights = new List<double>(){10,20,71,4,5};
           Console.WriteLine("Press 1 for minimum weight: ");
           Console.WriteLine("Press 2 for max ratio");
           Console.Write("Choose: ");
           string s = Console.ReadLine();
           if(s == "1"){
               MinWeight.GetProfit(weights,profits,30);
           }else if(s == "2"){
               MaxRatio.GetProfit(weights,profits,30);
           }else{
               Console.Write("invalid");
           }
           
           
        }
    }
}

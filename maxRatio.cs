using System;
using System.Collections;
using System.Collections.Generic;
namespace knapsnakProblem{
    namespace maxRatio{
        public class MaxRatio{
              private static void getProfit(List<Item> item, int capacity){
                 List<double> ratio = new List<double>();
                 int remainingCapacity = capacity;
                 foreach(Item i in item){
                     i.order = i.profit/ i.weight;
                     ratio.Add(i.order);
                 }
                 for(int i = 0 ; i < ratio.Count ; ++i){
                     for(int j = i+ 1; j < ratio.Count ; ++ j){
                         if(item[i].order < item[j].order){
                             Item temp = item[i];
                             item[i] = item[j];
                             item[j] = temp;
                         }
                     }
                 }
                 int index = ratio.Count;
                 double profit = 0;
                 for(int i = 0 ; i < index ; i++){
                     if(remainingCapacity > 0){
                       profit += item[i].profit;
                       remainingCapacity -= (int) item[i].weight;
                     }else{
                       profit += item[i].profit * remainingCapacity/item[i].weight;
                       break;
                     }
                 }
                 Console.WriteLine($"Profit: {profit}");
              }
              public static void GetProfit(List<double> weights, List<double> profits, int capacity){
                 List<Item> items = new List<Item>();
                 string algorithm = "Max Ratio";
                 for(int i = 0 ; i < weights.Count ; i++){
                     items.Add(new Item(i,profits[i],weights[i]));
                 }
                 Console.WriteLine($"Algorithm : {algorithm}");
                 getProfit(items,capacity);
               
              }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections;
namespace knapsnakProblem{
    namespace minWeight{
        class MinWeight{
            private static void sort(List<Item> item){
                for(int i = 0; i < item.Count ; ++i){
                    for(int j = i+ 1 ; j < item.Count ; ++j){
                        if(item[i].weight > item[j].weight){
                            Item temp = item[i];
                            item[i] = item[j];
                            item[j] = temp;
                        }
                    }
                }
            }
            public static void GetProfit(List<double> weight, List<double> profits, int capacity){
                double profit = 0;
                int remainingCapacity = capacity;
                List<Item> items = new List<Item>();
                for(int i = 0; i < weight.Count ; i++){
                    items.Add(new Item(i, profits[i], weight[i]));
                }
                sort(items);
                int index = items.Count;
                for(int i = 0 ; i < index ; i++){
                     if(remainingCapacity > 0){
                       profit += items[i].profit;
                       remainingCapacity -= (int) items[i].weight;
                     }else{
                       profit += items[i].profit * remainingCapacity/items[i].weight;
                       break;
                     }
                 }
                Console.WriteLine("Alogorithm: Minimum weight");
                Console.WriteLine($"Profit: {profit}");  
        }
      }
   }
}

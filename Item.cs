using System;
namespace knapsnakProblem{
     public class Item{
        public double order {get; set;}
        public double profit {get; set;}
        public double weight {get; set;}
        public Item(double order, double profit , double weight){
            this.order = order;
            this.profit = profit;
            this.weight = weight;
        }
    }
}
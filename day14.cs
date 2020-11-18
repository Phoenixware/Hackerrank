using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    public int maxValue = 0;
    public int minValue = 0;
    
   public Difference(int[] elements){
        this.elements = elements;
        Array.Sort(elements); 
    }
    
    public void computeDifference(){
        maxValue = elements.Max();
        minValue = elements.Min();
        maximumDifference = maxValue - minValue;
    }
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}

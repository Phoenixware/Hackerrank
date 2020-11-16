using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void Main(String[] args) {
    var n = Convert.ToInt32(Console.ReadLine());
    var phonebook = new Dictionary<string, string>();

    for (int i = 0; i < n; i++) {
      string[] inputs = Console.ReadLine().Split(' ');
      phonebook[inputs[0]] = inputs[1];
    }

    string queryKey;
    while ((queryKey = Console.ReadLine()) != null) {
      if (phonebook.ContainsKey(queryKey)) {
        Console.WriteLine("{0}={1}", queryKey, phonebook[queryKey]);
      } else {
        Console.WriteLine("Not found");
      }
    }
  }
}

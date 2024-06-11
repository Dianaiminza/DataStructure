using System;
using System.Collections.Generic;

public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random random;

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }

    public bool Insert(int val) {
        if (dict.ContainsKey(val)) {
            return false;
        }

        dict[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) {
            return false;
        }

        int lastElement = list[list.Count - 1];
        int idx = dict[val];

        list[idx] = lastElement;
        dict[lastElement] = idx;

        list.RemoveAt(list.Count - 1);
        dict.Remove(val);

        return true;
    }

    public int GetRandom() {
        int randomIndex = random.Next(list.Count);
        return list[randomIndex];
    }
}

class Program {
    static void Main() {
        RandomizedSet randomizedSet = new RandomizedSet();
        
        Console.WriteLine(randomizedSet.Insert(1)); // true
        Console.WriteLine(randomizedSet.Remove(2)); // false
        Console.WriteLine(randomizedSet.Insert(2)); // true
        Console.WriteLine(randomizedSet.GetRandom()); // 1 or 2
        Console.WriteLine(randomizedSet.Remove(1)); // true
        Console.WriteLine(randomizedSet.Insert(2)); // false
        Console.WriteLine(randomizedSet.GetRandom()); // 2
    }
}

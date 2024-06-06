using System;
using System.Collections.Generic;

public class RandomizedSet {
    private List<int> nums;
    private Dictionary<int, int> numToIndex;
    private Random rand;

    /** Initialize your data structure here. */
    public RandomizedSet() {
        nums = new List<int>();
        numToIndex = new Dictionary<int, int>();
        rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (numToIndex.ContainsKey(val)) {
            return false;
        }
        
        numToIndex[val] = nums.Count;
        nums.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!numToIndex.ContainsKey(val)) {
            return false;
        }
        
        int index = numToIndex[val];
        int lastElement = nums[nums.Count - 1];
        
        nums[index] = lastElement;
        numToIndex[lastElement] = index;
        
        nums.RemoveAt(nums.Count - 1);
        numToIndex.Remove(val);
        
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        int randomIndex = rand.Next(nums.Count);
        return nums[randomIndex];
    }
}

/**
 * Example usage:
 * RandomizedSet randomizedSet = new RandomizedSet();
 * Console.WriteLine(randomizedSet.Insert(1)); // Inserts 1 to the set. Returns true.
 * Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
 * Console.WriteLine(randomizedSet.Insert(2)); // Inserts 2 to the set, returns true. Set now contains [1,2].
 * Console.WriteLine(randomizedSet.GetRandom()); // getRandom() should return either 1 or 2 randomly.
 * Console.WriteLine(randomizedSet.Remove(1)); // Removes 1 from the set, returns true. Set now contains [2].
 * Console.WriteLine(randomizedSet.Insert(2)); // 2 was already in the set, so return false.
 * Console.WriteLine(randomizedSet.GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
 */


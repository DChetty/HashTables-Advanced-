using System;                      
using System.Collections.Generic; 
using System.Linq;                 
using System.Text;                 
using System.Threading.Tasks;       

namespace HashTablesAdvanced
{
    // This class implements a simple hash table using a custom hash function and custom nodes.
    public class CustomHash
    {
        // Array to store hash table data
        // The array holds instances of the CustomNode class, each representing a key-value pair.
        // The size of the array is 9, meaning it can store up to 9 key-value pairs.
        CustomNode[] hashdata = new CustomNode[9];

        // Method 1: GetHashData
        // This method calculates the hash code for a given key.
        // The hash code is calculated using the modulus operator, which ensures the hash code falls within the bounds of the hashdata array.
        public int GetHashData(int key)
        {
            // Compute the hash code by taking the modulus of the key with the length of the hashdata array.
            // This ensures that the hash code is always a valid index within the array.
            return key % hashdata.Length;
        }

        // Method 2: Add
        // This method adds a new key-value pair to the hash table.
        // If two keys produce the same hash code, the new key-value pair will overwrite the existing one (simple handling of collisions).
        public void Add(int key, string value)
        {
            // Calculate the hash code for the given key using the GetHashData method.
            // Store the new CustomNode at the computed index in the hashdata array.
            // This will overwrite any existing node at this index if a collision occurs (no collision resolution implemented).
            hashdata[GetHashData(key)] = new CustomNode(key, value);
        }

        // Method 3: Remove
        // This method removes a key-value pair from the hash table by setting the corresponding index in the array to null.
        public void Remove(int key)
        {
            // Calculate the hash code for the given key using the GetHashData method.
            // Set the corresponding index in the hashdata array to null, effectively removing the key-value pair.
            hashdata[GetHashData(key)] = null;
        }

        //fetch the data 
        public string GetHashTable()
        {
            string finalOutput = "";

            for (int i = 0; i < hashdata.Length; i++)
            {
                if (hashdata[i] != null)
                {
                    finalOutput += hashdata[i].ToString() + "\t";
                }
                else
                {
                    // if theres an empty value -> *****
                    finalOutput += "*\t";
                }
            }
            return finalOutput;
        }
    }
}

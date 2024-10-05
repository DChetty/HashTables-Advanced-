using System;                      // Required for basic input/output and core functionality.
using System.Collections.Generic;  // Provides interfaces and classes for generic collections.
using System.Linq;                 // Provides LINQ functionalities for querying collections.
using System.Text;                 // Provides classes representing ASCII, Unicode, and other encodings.
using System.Threading.Tasks;      // Provides types that simplify working with tasks, including asynchronous programming.

namespace HashTablesAdvanced
{
    // Definition of the CustomNode class
    // This class represents a custom data structure that holds a key-value pair.
    public class CustomNode
    {
        // Constructor for CustomNode
        // Takes an integer 'key' and a string 'value' as parameters to initialize the CustomNode object.
        public CustomNode(int key, string value)
        {
            this.key = key;       // Assign the provided key to the private field 'key'.
            this.value = value;   // Assign the provided value to the private field 'value'.
        }

        // Private fields for the key and value
        // These fields store the key-value pair and are not accessible directly outside the class.
        private int key { get; set; }      // Private field to store the key (integer).
        private string value { get; set; } // Private field to store the value (string).

        // Override the ToString() method
        // This method is called when an object is converted to a string (e.g., in Console.WriteLine()).
        public override string ToString()
        {
            // Return a formatted string representing the key-value pair.
            // Example output: (1 - "SampleValue")
            return "(" + key + " - " + value + ")";
        }
    }
}

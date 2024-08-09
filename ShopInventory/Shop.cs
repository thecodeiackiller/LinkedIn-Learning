using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{

    internal class Shop
    {
        
        Dictionary<int, string> items;

        public Shop() 
        {
            items = new Dictionary<int, string>();
        }


        public string this[int index]
        {
            get
            {
                if (items.ContainsKey(index))
                {
                    return items[index];
                }
                else
                {
                    throw new KeyNotFoundException("This item has not been added or assigned yet. Please add it to the dictionary.");
                }
            }
            set
            {
                try
                {
                    // Check if the key already exists
                    if (items.ContainsKey(index))
                    {
                        throw new ArgumentException("An item with the same key already exists.");
                    }

                    // Check if the value already exists
                    if (DuplicateItems(value))
                    {
                        throw new ArgumentException("This item has already been inserted.");
                    }

                    // Add the new key-value pair to the dictionary
                    items[index] = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    // Optionally rethrow the exception or handle it as needed
                    // throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    // Optionally rethrow the exception or handle it as needed
                    // throw;
                }

            }
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllPairs()
        {
            return items;
        }

        public bool DuplicateItems(string value)
        {
            foreach(var kvp in items.Values)
            {
                if(kvp.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


    }
}

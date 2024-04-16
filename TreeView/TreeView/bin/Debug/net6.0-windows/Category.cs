using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; }

        public Category(string name)
        {
            Name = name;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }

}

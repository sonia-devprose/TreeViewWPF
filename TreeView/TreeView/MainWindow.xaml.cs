using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Category> Categories { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Categories = new List<Category>();

            // Populate sample data
            PopulateInventory();

            // Set the DataContext to this window instance
            DataContext = this;
        }

        private void PopulateInventory()
        {
            // Create categories
            Category electronicsCategory = new Category("Electronics");
            electronicsCategory.AddItem(new Item("Laptop", 999.99m));
            electronicsCategory.AddItem(new Item("Smartphone", 499.99m));
            electronicsCategory.AddItem(new Item("Tablet", 299.99m)); // New item
            electronicsCategory.AddItem(new Item("Headphones", 79.99m)); // New item

            Category clothingCategory = new Category("Clothing");
            clothingCategory.AddItem(new Item("T-shirt", 19.99m));
            clothingCategory.AddItem(new Item("Jeans", 39.99m));
            clothingCategory.AddItem(new Item("Sweater", 49.99m)); // New item
            clothingCategory.AddItem(new Item("Dress", 59.99m)); // New item

            Category booksCategory = new Category("Books");
            booksCategory.AddItem(new Item("Novel", 14.99m));
            booksCategory.AddItem(new Item("Technical Manual", 29.99m));
            booksCategory.AddItem(new Item("Cookbook", 24.99m)); // New item
            booksCategory.AddItem(new Item("Self-Help", 19.99m)); // New item

            // Add categories to the list
            Categories.Add(electronicsCategory);
            Categories.Add(clothingCategory);
            Categories.Add(booksCategory);
        }

    }
}
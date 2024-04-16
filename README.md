# Mini Inventory App using TreeView in WPF

**Creating a WPF app in .NET6 using a TreeView UI**

![wpf-treeview-demo](https://github.com/sonia-devprose/TreeViewWPF/assets/161012720/af39fd4a-d6c9-4daf-9c13-4670fb348fd9)

This is a complete guide to creating a WPF Inventory Application with a styled TreeView. It covers defining model classes, implementing the main window (MainWindow) to display categorized items in a TreeView, defining custom styles for the TreeView and its items, and running the application to visualize the inventory. 

This is a complete guide to creating a WPF Inventory Application with a
styled TreeView. It covers defining model classes, implementing the main
window (MainWindow) to display categorized items in a TreeView, defining
custom styles for the TreeView and its items, and running the
application to visualize the inventory.

1\. Start by creating a new WPF Application project in Visual Studio.

2\. Define the Item and Category classes with properties to hold item
details such as name, price, and a collection of items within each
category.

3\. Main Window Implementation MainWindow.xaml: Define the main window
layout with a TreeView control bound to a collection of Category
objects.

4\. MainWindow.xaml.cs: Implement the logic to populate the TreeView
with sample data and set up data binding between the view model
(Categories collection) and the TreeView.

5\. TreeView Styling and Templating Resource Dictionary
(TreeViewStyles.xaml): Create a resource dictionary to define custom
styles for the TreeView and TreeViewItem controls

6\. Reference Resource Dictionary in App.xaml

7\. Running the Application Build and run the InventoryTreeViewDemo
project. The MainWindow will display a styled TreeView with three
top-level categories (Electronics, Clothing, Books), and each category
will contain sample items (Item objects). The TreeView nodes will be
styled according to the defined styles in TreeViewStyles.xaml, providing
a visually appealing and organized representation of the inventory.

8\. Applying Styling Create a Resource Dictionary:

Right-click on your project in the Solution Explorer. Choose Add \> New
Item\.... Select Resource Dictionary from the templates. Name the file
TreeViewStyles.xaml and click Add. Define Custom Styles:

Open TreeViewStyles.xaml in the code editor. Define Styles for TreeView
and TreeViewItem:

Inside TreeViewStyles.xaml, define the custom styles for the TreeView
and TreeViewItem. Referencing TreeViewStyles.xaml in App.xaml To make
the styles defined in TreeViewStyles.xaml available throughout your
application, you need to reference this resource dictionary in App.xaml.

Open App.xaml:

This file is located in the Properties folder of your project. Merge
TreeViewStyles.xaml into App.xaml:

Inside the \<Application.Resources\> section of App.xaml, add a
\<ResourceDictionary\> element and merge TreeViewStyles.xaml into it.

Now that you have defined the custom styles in TreeViewStyles.xaml and
referenced them in App.xaml, you can apply these styles to the TreeView
and TreeViewItem in MainWindow.xaml.

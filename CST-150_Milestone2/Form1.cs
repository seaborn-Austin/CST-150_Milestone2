using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Milestone2
{
    public partial class inventoryFrm : Form
    {
        public class  itemType
        {
            string name;

            public itemType(string n)
            {
                this.name = n;
            }
            
        }
        public class inventoryItem
        {
            public itemType n;
            public string name;
            public string sku;
            public string quantity;

        }
        public inventoryFrm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addItemBtn_Click(object sender, EventArgs e)
        {

            //https://www.youtube.com/watch?v=PAk31IekYj4
            //Learned more about listView from the above video
            //inventoryItem item = new inventoryItem();
            //item.name = itemNameTxt.Text;
            //item.sku = itemSkuTxt.Text;
            //item.quantity = quantityTxt.Text;
            //Using class Array for Inventory Manager to create our objects
            inventoryItem[] i = {
                new inventoryItem(), new inventoryItem(), new inventoryItem()
            };
            inventoryManager newItem = new inventoryManager(i);
            i[0].name = itemName.Text;
            i[0].sku = itemSkuTxt.Text;
            i[0].quantity = quantityTxt.Text;
            i[1].name = itemName.Text;
            i[1].sku = itemSkuTxt.Text;
            i[1].quantity = quantityTxt.Text;

            if (string.IsNullOrEmpty(itemNameTxt.Text) || string.IsNullOrEmpty(itemSkuTxt.Text) || 
                string.IsNullOrEmpty(quantityTxt.Text)) { return;  }
            

            ListViewItem subItem = new ListViewItem(i[0].name);
            //Add items to columns
                listView1.Items.Add(subItem);
                subItem.SubItems.Add(i[0].sku);
                subItem.SubItems.Add(i[0].quantity);
            
           
            itemNameTxt.Clear();
            itemSkuTxt.Clear();
            quantityTxt.Clear();
            itemNameTxt.Focus();

        }

        //Learned how to use listview from https://www.educative.io/answers/what-is-listview-in-c-sharp
        // Listview is being utilized to hold items that is input through the various
        // textboxes and added through the addItemBtn.
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Columns.Add("Name", 1000);
            //listView1.Columns.Add("SKU", 1000);
            //listView1.Columns.Add("Quantity", 1000);
        }

        private void inventoryFrm_Load(object sender, EventArgs e)
        {
            

            string[] arr = new string[3];
            ListViewItem item;
            arr[0] = itemNameTxt.Text;
            arr[1] = itemSkuTxt.Text;
            arr[2] = quantityTxt.Text;
            item = new ListViewItem(arr);
            listView1.Items.Add(item);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var item = listView1.FindItemWithText(searchTxt.Text);

            if (item != null)
            {
                MessageBox.Show(listView1.Items.IndexOf(item).ToString() + " "
                    + searchTxt.Text + " exists");
            }
            else { MessageBox.Show("That item is not in the list."); }
        }

        private void restockBtn_Click(object sender, EventArgs e)
        {
            var restock = listView1.SelectedItems;
            if (restock == listView1.SelectedItems)
            {
                MessageBox.Show(quantityTxt.Text + " " + itemNameTxt.Text + "'s reordered");
                
                
            }
        }
    }
}

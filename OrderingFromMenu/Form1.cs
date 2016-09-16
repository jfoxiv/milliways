using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingFromMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // For the Horde! (And the handlers.)
        private Dictionary<string, MenuItem> allMenuItems =
            new Dictionary<string, MenuItem>();

        public Dictionary<string, string> allBeverageItemKeys =
            new Dictionary<string, string>();

        public Dictionary<string, string> allAppetizerItemKeys =
            new Dictionary<string, string>();

        public Dictionary<string, string> allMainCourseItemKeys =
            new Dictionary<string, string>();

        public Dictionary<string, string> allDessertItemKeys =
            new Dictionary<string, string>();

        private bool comboBoxesLoaded = false;


        private void Form1_Load(object sender, EventArgs e) {
            // Populate a dictionary of all menu item objects.
            allMenuItems.Add("soda", new MenuItem("soda", "Soda", 1.95M, "beverage"));
            allMenuItems.Add("tea", new MenuItem("tea", "Tea", 1.50M, "beverage"));
            allMenuItems.Add("coffee", new MenuItem("coffee", "Coffee", 1.25M, "beverage"));
            allMenuItems.Add("mineralWater", new MenuItem("mineralWater", "Mineral Water", 2.95M, "beverage"));
            allMenuItems.Add("juice", new MenuItem("juice", "Juice", 2.50M, "beverage"));
            allMenuItems.Add("milk", new MenuItem("milk", "Milk", 1.50M, "beverage"));
            allMenuItems.Add("buffaloWings", new MenuItem("buffaloWings", "Buffalo Wings", 5.95M, "appetizer"));
            allMenuItems.Add("buffaloFingers", new MenuItem("buffaloFingers", "Buffalo Fingers", 6.95M, "appetizer"));
            allMenuItems.Add("potatoSkins", new MenuItem("potatoSkins", "Potato Skins", 8.95M, "appetizer"));
            allMenuItems.Add("nachos", new MenuItem("nachos", "Nachos", 8.95M, "appetizer"));
            allMenuItems.Add("mushroomCaps", new MenuItem("mushroomCaps", "Mushroom Caps", 10.95M, "appetizer"));
            allMenuItems.Add("shrimpCocktail", new MenuItem("shrimpCocktail", "Shrimp Cocktail", 12.95M, "appetizer"));
            allMenuItems.Add("chipsandSalsa", new MenuItem("chipsandSalsa", "Chips and Salsa", 6.95M, "appetizer"));
            allMenuItems.Add("seafoodAlfredo", new MenuItem("seafoodAlfredo", "Seafood Alfredo", 15.95M, "mainCourse"));
            allMenuItems.Add("chickenAlfredo", new MenuItem("chickenAlfredo", "Chicken Alfredo", 13.95M, "mainCourse"));
            allMenuItems.Add("chickenPicatta", new MenuItem("chickenPicatta", "Chicken Picatta", 13.95M, "mainCourse"));
            allMenuItems.Add("turkeyClub", new MenuItem("turkeyClub", "Turkey Club", 11.95M, "mainCourse"));
            allMenuItems.Add("lobsterPie", new MenuItem("lobsterPie", "Lobster Pie", 19.95M, "mainCourse"));
            allMenuItems.Add("primeRib", new MenuItem("primeRib", "Prime Rib", 20.95M, "mainCourse"));
            allMenuItems.Add("shrimpScampi", new MenuItem("shrimpScampi", "Shrimp Scampi", 18.95M, "mainCourse"));
            allMenuItems.Add("turkeyDinner", new MenuItem("turkeyDinner", "Turkey Dinner", 13.95M, "mainCourse"));
            allMenuItems.Add("stuffedChicken", new MenuItem("stuffedChicken", "Stuffed Chicken", 14.95M, "mainCourse"));
            allMenuItems.Add("applePie", new MenuItem("applePie", "Apple Pie", 5.95M, "dessert"));
            allMenuItems.Add("sundae", new MenuItem("sundae", "Sundae", 3.95M, "dessert"));
            allMenuItems.Add("carrotCake", new MenuItem("carrotCake", "Carrot Cake", 5.95M, "dessert"));
            allMenuItems.Add("mudPie", new MenuItem("mudPie", "Mud Pie", 4.95M, "dessert"));
            allMenuItems.Add("appleCrisp", new MenuItem("appleCrisp", "Apple Crisp", 5.95M, "dessert"));

            // Some "Hitchhiker's Guide" cocktails for local color.
            allMenuItems.Add("jynnanTonnyx", new MenuItem("jynnanTonnyx", "Jynnan Tonnyx", 6.50M, "beverage"));
            allMenuItems.Add("panGalactic", new MenuItem("panGalactic", "Pangalactic Gargle Blaster", 19.95M, "beverage"));
            allMenuItems.Add("jovianSunspot", new MenuItem("jovianSunspot", "Jovian Sunspot", 5.95M, "beverage"));
            allMenuItems.Add("veganRhino", new MenuItem("veganRhino", "Vegan Rhino", 9.95M, "appetizer"));
            allMenuItems.Add("pearsGallumbit", new MenuItem("pearsGallumbit", "Pears Gallumbit", 9.95M, "dessert"));
            allMenuItems.Add("amegMajorCow", new MenuItem("amegMajorCow", "Cut of Aeglion Major Cow", 24.95M, "mainCourse"));



            // Each item category gets its own dictionary, and each dictionary is
            // data-bound to its corresponding combobox (e.g. allBeverageItemKeys
            // is data-bound to comboBoxBeverages. Once the binding is complete,
            // the comboboxes are automagically populated!
            foreach (KeyValuePair<string, MenuItem> entry in allMenuItems) {
                if (entry.Value.ItemCategory == "beverage")
                    allBeverageItemKeys.Add(entry.Value.DictKey, entry.Value.DisplayText);
            }
            comboBoxBeverages.DataSource = new BindingSource(allBeverageItemKeys, null);
            comboBoxBeverages.DisplayMember = "Value";
            comboBoxBeverages.ValueMember = "Key";

            // Appetizers dictionary and combobox
            foreach (KeyValuePair<string, MenuItem> entry in allMenuItems) {
                if (entry.Value.ItemCategory == "appetizer")
                    allAppetizerItemKeys.Add(entry.Value.DictKey, entry.Value.DisplayText);
            }
            comboBoxAppetizers.DataSource = new BindingSource(allAppetizerItemKeys, null);
            comboBoxAppetizers.DisplayMember = "Value";
            comboBoxAppetizers.ValueMember = "Key";

            // Main courses dictionary and combobox
            foreach (KeyValuePair<string, MenuItem> entry in allMenuItems) {
                if (entry.Value.ItemCategory == "mainCourse")
                    allMainCourseItemKeys.Add(entry.Value.DictKey, entry.Value.DisplayText);
            }
            comboBoxMainCourses.DataSource = new BindingSource(allMainCourseItemKeys, null);
            comboBoxMainCourses.DisplayMember = "Value";
            comboBoxMainCourses.ValueMember = "Key";

            // Desserts dictionary and combobox
            foreach (KeyValuePair<string, MenuItem> entry in allMenuItems) {
                if (entry.Value.ItemCategory == "dessert")
                    allDessertItemKeys.Add(entry.Value.DictKey, entry.Value.DisplayText);
            }
            comboBoxDesserts.DataSource = new BindingSource(allDessertItemKeys, null);
            comboBoxDesserts.DisplayMember = "Value";
            comboBoxDesserts.ValueMember = "Key";

            // Okay, comboboxen are all loaded up!
            comboBoxesLoaded = true;

        } // end method Form1_Load



        private void buttonQuit_Click(object sender, EventArgs e) {
            decimal gratuity = .15M * MenuItem.RunningOrderTotal;
            // TODO: only pop tip box when running total is nonzero.
            if (MenuItem.RunningOrderTotal > 0M) {
                string formattedGratuity = "$" + gratuity.ToString("0.00");
                MessageBox.Show(String.Format("15% gratuity is {0}!", formattedGratuity));
            }
            Application.Exit();
        }

        private void buttonClearFields_Click(object sender, EventArgs e) {
            // Clear out text fields. Also, don't forget to reset the
            // running total!
            textBoxItemPrice.Text    = null;
            textBoxItemTax.Text      = null;
            textBoxItemSubtotal.Text = null;
            textBoxRunningTotal.Text = null;
            MenuItem.RunningOrderTotal = 0;

        }

        private void comboBoxBeverages_SelectedIndexChanged(
            object sender, EventArgs e) {
            /*
             * Got a bit of a strange thing here, in that it appears that 
             * when Form1_Load binds stuff to a combobox it may be triggering
             * this particular handler. Resolved this by only processing the
             * event if Form1_Load has finished binding the comboboxes to
             * dictionaries.
             */
            if (comboBoxesLoaded != false) {
                string itemKey = comboBoxBeverages.SelectedValue.ToString();

                decimal itemPrice = allMenuItems[itemKey].ItemPrice;
                decimal itemTax = allMenuItems[itemKey].CalcItemTax(itemPrice);
                decimal itemSubtotal = itemPrice + itemTax;
                MenuItem.RunningOrderTotal += itemSubtotal;

                textBoxItemPrice.Text = "$" +
                    itemPrice.ToString("0.00");

                textBoxItemTax.Text = "$" +
                    itemTax.ToString("0.00");

                textBoxItemSubtotal.Text = "$" +
                    itemSubtotal.ToString("0.00");

                textBoxRunningTotal.Text = "$" +
                    MenuItem.RunningOrderTotal.ToString("0.00");
            }

        } // end comboBoxBeverages_SelectedIndexChanged()

        private void comboBoxAppetizers_SelectedIndexChanged(
            object sender, EventArgs e) {

            if (comboBoxesLoaded != false) {
                string itemKey = comboBoxAppetizers.SelectedValue.ToString();
                decimal itemPrice = allMenuItems[itemKey].ItemPrice;
                decimal itemTax = allMenuItems[itemKey].CalcItemTax(itemPrice);
                decimal itemSubtotal = itemPrice + itemTax;
                MenuItem.RunningOrderTotal += itemSubtotal;

                textBoxItemPrice.Text = "$" +
                    itemPrice.ToString("0.00");

                textBoxItemTax.Text = "$" +
                    itemTax.ToString("0.00");

                textBoxItemSubtotal.Text = "$" +
                    itemSubtotal.ToString("0.00");

                textBoxRunningTotal.Text = "$" +
                    MenuItem.RunningOrderTotal.ToString("0.00");
            }
        }

        private void comboBoxMainCourses_SelectedIndexChanged(
            object sender, EventArgs e) {

            if (comboBoxesLoaded != false) {
                string itemKey = comboBoxMainCourses.SelectedValue.ToString();
                decimal itemPrice = allMenuItems[itemKey].ItemPrice;
                decimal itemTax = allMenuItems[itemKey].CalcItemTax(itemPrice);
                decimal itemSubtotal = itemPrice + itemTax;
                MenuItem.RunningOrderTotal += itemSubtotal;

                textBoxItemPrice.Text = "$" +
                    itemPrice.ToString("0.00");

                textBoxItemTax.Text = "$" +
                    itemTax.ToString("0.00");

                textBoxItemSubtotal.Text = "$" +
                    itemSubtotal.ToString("0.00");

                textBoxRunningTotal.Text = "$" +
                    MenuItem.RunningOrderTotal.ToString("0.00");
            }
        }

        private void comboBoxDesserts_SelectedIndexChanged(
            object sender, EventArgs e) {

            if (comboBoxesLoaded != false) {
                string itemKey = comboBoxDesserts.SelectedValue.ToString();

                decimal itemPrice = allMenuItems[itemKey].ItemPrice;
                decimal itemTax = allMenuItems[itemKey].CalcItemTax(itemPrice);
                decimal itemSubtotal = itemPrice + itemTax;
                MenuItem.RunningOrderTotal += itemSubtotal;

                textBoxItemPrice.Text = "$" +
                    itemPrice.ToString("0.00");

                textBoxItemTax.Text = "$" +
                    itemTax.ToString("0.00");

                textBoxItemSubtotal.Text = "$" +
                    itemSubtotal.ToString("0.00");

                textBoxRunningTotal.Text = "$" +
                    MenuItem.RunningOrderTotal.ToString("0.00");
            }
        }

    } // end partial class Form1

} // end namespace
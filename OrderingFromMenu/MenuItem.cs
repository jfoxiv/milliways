using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingFromMenu {
    public class MenuItem : object{
        // This awesome class is the heart of the application.
        // Look upon it and despair! Or whatever.

        // Instance and static variables.
        private string dictKey;
        private string itemName;
        private decimal itemPrice;
        private string itemCategory;

        private static decimal taxRate = .1M;
        private static decimal runningOrderTotal;        

        
        // constructor
        public MenuItem(string key, string name, decimal price, string category) {
            dictKey = key;
            itemName = name;
            itemPrice = price;
            itemCategory = category;
        }

        public static decimal RunningOrderTotal {
            get {
                return runningOrderTotal;
            }
            set {
                if (value.GetType().ToString() == "System.Decimal")
                    runningOrderTotal = value;
                else
                    throw new ArgumentException(String.Format(
                        "{0} must be of type decimal!", value), "value");
            }
        }// end property RunningOrderTotal

        public string DisplayText {
            get {
                return this.ToString();
            }
        }

        public string DictKey {
            get {
                return dictKey;
            }
            set {
                if(value.GetType().ToString() == "System.String")
                    dictKey = value;
                else
                    throw new ArgumentException(String.Format(
                        "{0} must be of type string!", value), "value");
            }
        }// end property DictKey


        public string ItemName {
            get {
                return itemName;
            }
            set {
                itemName = value;
            }
        } // end property ItemName

        public decimal ItemPrice {
            get {
                return itemPrice;
            }
            set {
                if(value.GetType().ToString() == "System.Decimal" )
                    itemPrice = value;
                else
                    throw new ArgumentException(String.Format(
                        "{0} must be of type decimal", value), "value");
            }
        } // end property ItemPrice

        public string ItemCategory {
            // no "set" because the foods won't be recategorized
            get {
                return itemCategory;
              }
        } // end property ItemCategory

        public decimal CalcItemTax(decimal price) {
            return price * taxRate;
        } // end method CalcItemTax

        public override string ToString() {
            return String.Format("{0} $({1})", itemName, itemPrice);
        } // end method TOString

    }// end class MenuItem
}// end namespace definition


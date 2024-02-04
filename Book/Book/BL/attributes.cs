using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.BL
{
    internal class attributes
    {
        public string Title;
        public string Author;
        public int PublicationYear;
        public float Price;
        public int Quantity;

        public string GetTitle()
        {
            string t = "Title: " + Title;
            return t;
        }

        public string GetAuthor()
        {
            string t = "Author: " + Author;
            return t;
        }

        public string GetPublicationYear()
        {
            string t = "Publication Year: " + PublicationYear.ToString();
            return t;

        }
        public string GetPrice()
        {
            string t = "Price: " + Price.ToString();
            return t;
        }
        public string Sell(int Copies)
        {
            string t;
            if (Quantity > Copies)
            {
                Quantity -= Copies;
                t = "Copies Sold";
            }
            else
            {
                t = "Not Enough Copies";
            }
            return t;
        }

        public string Restock(int Copies)
        {
            string t = "Stock Added";
            Quantity += Copies;
            return t;
        }
        public string BookDetail()
        {
            string t;
            t = "Title: " + Title + "\t\t\tAuthor: " + Author + "\t\t\tPublication Year: " + PublicationYear.ToString() + "\t\t\tPrice: " + Price.ToString() + "\t\t\tCurrent Quantity: " + Quantity.ToString();
            return t;
        }

    }
}

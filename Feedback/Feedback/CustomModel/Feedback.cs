using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedback.CustomModel
{
    public class Feedback
    {
        List<Product> ProductList
        {
            get;
            set;
        }

        List<Category> CategoryList
        {
            get;
            set;
        }

        List<Country> CountryList
        {
            get;
            set;
        }

        List<Satisfactory> SatisfactorieList
        {
            get;
            set;
        }

        List<Title> TitleList
        {
            get;
            set;
        }

        public string Comment
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string Initial
        {
            get; set;
        }

        public string StreetAddress
        {
            get; set;
        }

        public string StreetAddressLine
        {
            get; set;
        }

        public string City
        {
            get; set;
        }

        public string Region
        {
            get; set;
        }

        public int Zipcode
        {
            get; set;
        }

        public string Reason
        {
            get; set;
        }

        
    }
}
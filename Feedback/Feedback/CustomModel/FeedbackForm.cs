using Microsoft.AspNetCore.Http;

namespace Feedback.CustomModel
{
    public class FeedbackForm
    {
        public int Category
        {
            get; set;
        }


        public int Product
        {
            get; set;
        }


        public int Country
        {
            get; set;
        }

        public int Satisfactory
        {
            get; set;
        }


        public int Title
        {
            get; set;
        }

        public int Product2
        {
            get; set;
        }

        public string Comment
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string Email
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

        public IFormFile FeedbackFile
        {
            get; set;
        }

    }
}
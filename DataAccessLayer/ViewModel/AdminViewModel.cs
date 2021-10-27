using DataAccessLayer.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.ViewModel
{
    public class AdminViewModel
    {
        public int Id
        {
            get; set;
        }

        [Required(ErrorMessage = "User Id is required")]
        [Display(Name = "User Id")]
        public int? UserId
        {
            get; set;
        }

        [Required(ErrorMessage = "Event type Id is required")]
        [Display(Name = "Event Type Id")]
        public int? EventTypeId
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Title length can't be more than 100.")]
        [DataType(DataType.Text)]
        public string Title
        {
            get; set;
        }

        [Required]
        [StringLength(500, ErrorMessage = "Description length can't be more than 500.")]
        [DataType(DataType.Text)]
        public string Description
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Address length can't be more than 100.")]
        [DataType(DataType.Text)]
        public string Address
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        [DataType(DataType.Text)]
        public string Name
        {
            get; set;
        }


        [Required]
        [StringLength(50, ErrorMessage = "City length can't be more than 50.")]
        [DataType(DataType.Text)]
        public string City
        {
            get; set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Owner length can't be more than 50.")]
        [DataType(DataType.Text)]
        public string Owner
        {
            get; set;
        }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date Time")]
        public DateTime StartDateTime
        {
            get; set;
        }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "End Date Time")]
        public DateTime EndDateTime
        {
            get; set;
        }



        public DateTime CreatedAt
        {
            get; set;
        }



        public virtual EventType EventType
        {
            get; set;
        }


        public virtual UserTbl User
        {
            get; set;
        }


    }
}

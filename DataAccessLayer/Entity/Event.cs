using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccessLayer.Entity
{
    public partial class Event
    {
        public int Id
        {
            get; set;
        }

        [Required(ErrorMessage = "User Id is required")]
        public int? UserId
        {
            get; set;
        }

        [Required(ErrorMessage = "Event type Id is required")]
        public int? EventTypeId
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Title
        {
            get; set;
        }

        [Required]
        [StringLength(500, ErrorMessage = "Name length can't be more than 500.")]
        public string Description
        {
            get; set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Address
        {
            get; set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string City
        {
            get; set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Owner
        {
            get; set;
        }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDateTime
        {
            get; set;
        }

        [Required]
        [DataType(DataType.DateTime)]
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

namespace Feedback.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserDetail")]
    public partial class UserDetail
    {
        public int UserDetailId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(3)]
        public string UserId { get; set; }

        public int TitleId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(5)]
        public string Initial { get; set; }

        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        public int UserAddressId { get; set; }

        public virtual Title Title { get; set; }

        public virtual UserAddress UserAddress { get; set; }
    }
}

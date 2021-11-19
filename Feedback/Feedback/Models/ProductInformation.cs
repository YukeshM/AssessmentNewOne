namespace Feedback.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductInformation")]
    public partial class ProductInformation
    {
        public int ProductInformationId { get; set; }

        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        public int SatisfactoryId { get; set; }

        public int PurchasedProductInTwoMonth { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        public virtual Category Category { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual Product Product { get; set; }

        public virtual Satisfactory Satisfactory { get; set; }
    }
}

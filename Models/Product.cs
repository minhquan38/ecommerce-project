using project.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPictureURL { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public int ProductAvailability { get; set; }
    }
}

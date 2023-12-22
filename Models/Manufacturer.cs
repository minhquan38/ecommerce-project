using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Manufacturer
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandPictureURL { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        //Relationships
        public List<Product> Products { get; set; }
    }
}

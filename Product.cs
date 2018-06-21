using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{
    [Table("Product",Schema ="Production")]
     public class Product
    {    
        [Display(Name ="شناسه محصول")]
        public int Id { get; set; }
        [MaxLength(50),Required]
        //[Index(IsUnique =true)]
        [Display(Name = "نام تابلو")]
        public string  NameBoard { get; set; }
        //public string ModelName { get; set; }
        [Display(Name = "قیمت اولیه")]
        public decimal FirstPrice { get; set; }
        [Display(Name = "درصد تخفیف")]
        public double Reduction { get; set; }
        [Display(Name = " قیمت نهایی ")]
        public decimal LastPrice { get; set; }
        [Display(Name = "وجود محصول")]
        public bool IsAvailable { get; set; }
        [Display(Name = "تعداد")]
        public int Number { get; set; }
        [Display(Name = "مدت ضمانت")]
        public int TimeGaranty { get; set; }
         [MaxLength(150)]
        [Display(Name = "آپلود عکس")]
        public string UrlImage { get; set; }
        [Display(Name = "دسته بندی")]
        public virtual Category Category { get; set; }
        [Display(Name = "دسته بندی")]
        public int? CategoryId { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{ 
    public class DetailProductPainting:Product
    {   /*public int Id { get; set; }*/
        //[MaxLength(30)]
        //public string NameBoard { get; set; }//نام تابلو
        [MaxLength(30)]
        [Display(Name = "نام هنرمند")]
        public string NameArtist { get; set; } 
        [MaxLength(20)]
        [Display(Name = "سایزتابلو")]
        public string SizeBoard { get; set; }
        [MaxLength(25)]
        [Display(Name = "تکنیک")]
        public string Technique { get; set; }//تکنیک(سیاه قلم،رنگ روغن  
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location: IEntity
    {
        [Key]
        public int location_id { get; set; } //lokasyon id
        [Display(Name = "Lokasyon Başlığı")]

        public string title { get; set; } //lokasyon başlık
        public string description { get; set; } // lokasyon açıklama
        [ForeignKey("Region")]
        [Display(Name = "Ait Olduğu Bölge ")]
        public int regionId { get; set; } //bölge ıdsi////////////////////////////////////////////
        public int image_id { get; set; } //lokasyon resim////////////////////////////////////////////
        public int row { get; set; } //bölge sırası////////////////////////////////////////////
        public bool? state { get; set; } //lokasyon görünme durumu
        public bool? IsChecked { get; set; } //lokasyon silinip silinmediği

        public virtual Region Region { get; set; }

    }
}

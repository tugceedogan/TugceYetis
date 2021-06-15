using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class location: Core.Entities.IEntity
    {
        [Key]
        public int location_id { get; set; } //lokasyon id
        public string title { get; set; } //lokasyon başlık
        public string description { get; set; } // lokasyon açıklama
        public int image_id { get; set; } //lokasyon resim////////////////////////////////////////////
        public bool? state { get; set; } //lokasyon görünme durumu
        public bool? IsChecked { get; set; } //lokasyon silinip silinmediği



    }
}

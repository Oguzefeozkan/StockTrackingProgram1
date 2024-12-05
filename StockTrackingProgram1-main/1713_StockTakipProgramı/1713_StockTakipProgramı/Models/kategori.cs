using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1713_StockTakipProgramı.Models
{
    public class kategori
    {
        [Key]

        public int Id { get; set; }

        public String KatogeriAdı { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();

    }
}

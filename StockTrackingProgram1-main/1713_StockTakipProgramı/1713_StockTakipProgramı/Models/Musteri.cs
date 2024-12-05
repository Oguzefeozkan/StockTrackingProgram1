using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1713_StockTakipProgramı.Models
{
    public class Musteri
    {
        [Key]

        public int Id { get; set; }

        public string MusteriAdi { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();

    }
}

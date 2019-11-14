using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGirisi.ORM.Entity
{
    public class Kiralama : BaseEntitiy
    {


        public int ArabaID { get; set; }
        public virtual Arabalar arabalar { get; set; }

        public int MusteriID { get; set; }
        public virtual Musteriler musteriler { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KiralanmaSuresi { get; set; }
        public double FaturaTutari { get; set; }
       
    }
}

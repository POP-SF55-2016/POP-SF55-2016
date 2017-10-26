using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF55_2016.Model
{
    public class Akcija
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public decimal Popust { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public double ProcenatPopusta { get; set; }
        public bool Obrisan { get; set; }

    }
}

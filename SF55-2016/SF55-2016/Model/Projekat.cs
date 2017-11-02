using SF55_2016.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF55_2016.Model
{
    public class Projekat
    {
        public static Projekat Instance { get; private set; } = new Projekat();

        private List<TipNamestaja> tipoviNamestaja;

        public List<TipNamestaja> TipoviNamestaja
        {
            get
            {
                tipoviNamestaja = Utils.GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");
                return tipoviNamestaja;
            }
            set
            {
                tipoviNamestaja = value;
                GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", tipoviNamestaja);
            }
        }


        public Projekat() 
        {
            Instance = new Projekat();
        }
    }
}

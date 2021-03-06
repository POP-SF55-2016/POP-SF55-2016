﻿using SF55_2016.Model;
using SF55_2016.Tests;
using SF55_2016.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF55_2016
{
    class Program
    {
        private static List<Namestaj> Namestaj = new List<Namestaj>();
        private static List<TipNamestaja> TipNamestaja = new List<TipNamestaja>();

        public static object TipoviNamestaja { get; private set; }

        static void Main(string[] args)
        {
            Salon s1 = new Salon()
            {
                Id = 1,
                Adresa = "Trg Dositeja Obradovica 6",
                BrojZiroRacuna = "840-000171666-45",
                Email = "dekan@ftn.uns.ac.rs",
                MaticniBroj = 324324324,
                Naziv = "Forma FTNale",
                PIB = 123123,
                Telefon = "021/454-3434",
                Web = "http://www.ftn.uns.ac.rs"
            };

            var tp1 = new TipNamestaja()
            {
                Id = 1,
                Naziv = "Krevet",
            };

            var n1 = new Namestaj()
            {
                Id = 1,
                Cena = 777,
                TipNamestaja = tp1,
                Naziv = "Ekstra krevet socijalni",
                KolicinaUMagacinu = 777,
            };

            var listaTipovaNamestaja = new List<TipNamestaja>();
            listaTipovaNamestaja.Add(tp1);



            //GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", listaTipovaNamestaja);
            var listaTipovaNamestaja = Projekat.Instance.TipoviNamestaja;

            var noviTipNamestaja = new TipNamestaja()
            {
                Id = listaTipovaNamestaja.Count + 1,
                Naziv = "Ugaona"
            };

            listaTipovaNamestaja.Add(noviTipNamestaja);
            Projekat.Instance.TipoviNamestaja = listaTipovaNamestaja;

            Console.WriteLine("Finished serialization...");

            Console.ReadLine();

            Console.WriteLine("Dobrodosli u salon" + s1.Naziv);

            IspisiGlavniMeni();
        }
        private static void IspisiGlavniMeni()
        {
            int izbor = 0;

            do
            {
                do
                {
                    Console.WriteLine("1. Rad sa namestajem");
                    Console.WriteLine("2. Rad sa tipom namestaja");
                    // dovrsiti kod kuce
                    Console.WriteLine("0. Izlaz iz aplikacije");

                    izbor = int.Parse(Console.ReadLine());
                } while (izbor < 0 || izbor > 2);

                switch (izbor)
                {
                    case 1:
                        NamestajMeni();
                        break;
                    default:
                        break;
                }
            } while (izbor != 0);
        }
        private static void NamestajMeni()
        {
            int izbor = 0;
            do
            {

            } while (izbor != 0);

            do
            {
                Console.WriteLine("RAD SA NAMESTAJEM");
                IspisiCRUDMeni();

                izbor = int.Parse(Console.ReadLine());

            } while (izbor < 0 || izbor > 4);

            switch (izbor)
            {
                case 1:
                    PrikaziNamestaj();
                    break;
                case 2: 
                    DodajNamestaj();
                    break;
                case 3:
                    IzmeniNamestaj();
                    break;
                case 4:
                    ObrisiNamestaj();
                    break;
                default:
                    break;

            } while (izbor != 0) ;
        }
            private static void IzmeniNamestaj()
        {

        }
            private static void ObrisiNamestaj()
        {

        }

            private static void DodajNamestaj()
        {
            Console.WriteLine("DODAVANJE NOVOG NAMESTAJA");
            Console.WriteLine("Unesite naziv");
            string naziv = Console.ReadLine();

            Console.WriteLine("Unesite cenu");
            double cena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite IDtipa namestaja:");
            string idTipaNamestaja = int.Parse(Console.ReadLine());

            TipNamestaja trazeniTipNamestaja = null;
            foreach (var tipNamestaja.Id == TipoviNamestaja)
            {
                if (tipNamestaja in TipoviNamestaja)
                {
                    trazeniTipNamestaja = tipNamestaja;

                }

            }

            var noviNamestaj = new Namestaj()
            {
                Id = Namestaj.Count + 1,
                Naziv = naziv,
                Cena = cena,
                TipNamestaja = trazeniTipNamestaja
            };

            Namestaj.Add(noviNamestaj);
        }
            private static void PrikaziNamestaj() 
        {
            Console.WriteLine("Lista namestaja");
            for (int i = 0; i <  Namestaj.Count; i++)
            {
                Console.WriteLine($"(i + 1). naziv: {Namestaj[i].Naziv }, cena: { Namestaj[i].Cena}, tip namestaja: { Namestaj[i].TipNamestaja.Naziv}");

            }
        }
            private static void IspisiCRUDMeni()
        {
            Console.WriteLine("0. Prikazi listing");
            Console.WriteLine("1. Dodaj novi namestaj");
            Console.WriteLine("2. Izmeni postojeci");
        }
        
    }
}
        
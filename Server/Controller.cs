using Common;
using Common.Model;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace Server
{
    public class Controller
    {

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        private Controller()
        {
            repository = new GenericDBRepository();
        }

        private IDBRepository<IEntity> repository;


        public Korisnik CurrentUser { get; private set; }


        public object Login(Korisnik kor)
        {
            SOLogin SOLogin = new SOLogin();
            SOLogin.Korisnik = kor;
            SOLogin.Execute();

            return SOLogin.Korisnik;
        }

        ////// Namirnice 
        

        internal List<Namirnica> VratiNamirnice()
        {
            SystemOperationBase so = new SOVratiNamirnice();
            so.Execute();
            return ((SOVratiNamirnice)so).Namirnice;
        }

        internal Namirnica UnosNamirnice(Namirnica nam)
        {
            SOUnosNamirnice so = new SOUnosNamirnice();
            so.nam = nam;
            so.Execute();
            Console.WriteLine("Controller prosao"); 
            return so.nam;
        }

        internal void IzmenaNamirnice(Namirnica namirnica)
        {
            SOIzmenaNamirnice so = new SOIzmenaNamirnice();
            so.nam = namirnica;
            so.Execute();
        }

        //internal void BrisanjeNamirnice(Namirnica nam)
        //{
        //    SOBrisanjeNamirnice so = new SOBrisanjeNamirnice();
        //    so.nam = nam;
        //    so.Execute();
        //}



        ////// Jela
        


        internal List<Jelo> VratiJela()
        {
            SystemOperationBase so = new SOVratiJela();
            so.Execute();
            return ((SOVratiJela)so).Jela;  
        }

        internal Jelo UnosJela(Jelo argument)
        {
            SOUnosJela so = new SOUnosJela();
            so.jelo = argument; 
            so.Execute();
            Console.WriteLine("Controller prosao");
            return so.jelo;
        }

        internal List<VrstaJela> VratiVrsteJela()
        {
            SystemOperationBase so = new SOVratiVrsteJela();
            so.Execute();
            return ((SOVratiVrsteJela)so).vrsteJela;
        }

        internal void IzmenaJela(Jelo jelo)
        {
            SOIzmenaJela so = new SOIzmenaJela();
            so.jelo = jelo;
            so.Execute();
        }

        internal Recept UnosRecepta(Recept recept)
        {
            SODodajRecept so = new SODodajRecept();
            so.recept = recept;
            so.profil = recept.ProfilIshrane;
            so.Execute();
            return so.recept;
        }

        internal List<Recept> VratiRecepte()
        {
            SystemOperationBase so = new SOVratiRecepte();
            so.Execute();
            return ((SOVratiRecepte)so).recepti;
        }

        internal object VratiSR()
        {
            throw new NotImplementedException();
        }

        internal void IzmenaRecepta(Recept rec)
        {
            SOIzmeniRecept so = new SOIzmeniRecept();
            so.recept = rec;
            so.Execute();
            
        }

        internal Namirnica UcitajNamirnicu(Namirnica argument)
        {
            SOUcitajNamirnicu so = new SOUcitajNamirnicu();
            so.nam = argument;
            so.Execute();
            return so.nam;
        }

        internal Jelo UcitajJelo(Jelo argument)
        {
            SOUcitajJelo so = new SOUcitajJelo();
            so.jelo = argument;
            so.Execute();
            return so.jelo;
        }

        internal List<Jelo> NadjiJelo(Jelo jelo)
        {
            SONadjiJela so = new SONadjiJela();
            so.jelo = jelo;
            so.Execute();
            return so.Result;
        }

        internal List<Namirnica> NadjiNamirnice(Namirnica nam)
        {
            SONadjiNamirnice so = new SONadjiNamirnice();
            so.namirnica = nam;
            so.Execute();
            return so.Result;
        }

        internal Recept UcitajRecept(Recept recept)
        {
            SOUcitajRecept so = new SOUcitajRecept();
            so.recept = recept;
            so.Execute();
            return so.recept;
        }

        internal List<Recept> NadjiRecept(Recept argument)
        {
            SOPronadjiRecepte so = new SOPronadjiRecepte();
            so.recept = argument;
            so.Execute();
            return so.Result;

        }

        internal void ObrisiRecept(Recept argument)
        {
            SOOBrisiRecept so = new SOOBrisiRecept();
            so.recept = argument;
            so.Execute();
        }
    }
}

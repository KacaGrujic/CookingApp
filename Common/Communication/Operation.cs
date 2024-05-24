using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        Logout,
        //Namirnica
        VratiNamirnice,
        UcitajNamirnicu,
        DodajNamirnicu,
        IzmeniNamirnicu,
        ObrisiNamirnicu,
        //Jelo
        VratiJela,
        UcitajJelo,
        DodajJelo,
        IzmeniJelo,
        ObrisiJelo,
        //VrstaJela
        VratiVrsteJela,
        //Recept
        VratiRecepte,
        UcitajRecept,
        DodajRecept,
        IzmeniRecept,
        ObrisiRecept,
        VratiStavkeRecepta,
        NadjiJelo,
        NadjiNamirnice,
        NadjiRecept,
        Odjavljivanje,
    }
}

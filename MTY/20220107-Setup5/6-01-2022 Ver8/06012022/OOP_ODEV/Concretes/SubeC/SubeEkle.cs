using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV.Concretes.SubeC
{

    class SubeEkle
    {
        Context db;
        public SubeEkle(string ad, int id, string mail, string telefon, string adres)
        {
            db = new Context();

            Sube sube = new Sube();
            sube.SubeAdi = ad;
            sube.SubeMail = mail;
            sube.SubeTelefon = telefon;
            sube.SubeAdresi = adres;
            sube.IsActive = true;

            db.Subeler.Add(sube);

            if (db.Koordinatorler.FirstOrDefault(x => x.KoordinatorID == id) != null) db.Koordinatorler.FirstOrDefault(x => x.KoordinatorID == id).SubeID = sube.SubeID;

            db.SaveChanges();
        }
        public SubeEkle(string ad, string mail, string telefon, string adres)
        {
            db = new Context();

            Sube sube = new Sube();
            sube.SubeAdi = ad;
            sube.SubeMail = mail;
            sube.SubeTelefon = telefon;
            sube.SubeAdresi = adres;
            sube.IsActive = false;

            db.Subeler.Add(sube);
            db.SaveChanges();
        }
    }
}

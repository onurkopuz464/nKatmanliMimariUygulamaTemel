using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List <EntityPersonel> LLPersonelListesi()
        {
            return DALPERSONEL.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 3500 && p.Ad.Length >= 3) // Şart ekledik ekleme kısmına
            {
                return DALPERSONEL.PersonelEkle(p);

            }
            else
            {
                return -1;
            }

        }
        public static bool LLPERSONELsil(int per)
        {
            if(per >= 1)
            {
                return DALPERSONEL.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if(ent.Ad.Length>= 3 && ent.Ad!="") 
            {
                return DALPERSONEL.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
   

}

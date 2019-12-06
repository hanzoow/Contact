using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Models.Entity
{
    public class NhomDanhBa
    {
        [Key]
        public string TenNhom { get; set; }


        public static void Remove(NhomDanhBa nhom)
        {
            var db = new KiemTraDBContext();
            var ojbSV = db.NhomDanhBaDbSet.Where(e => e.TenNhom == nhom.TenNhom).FirstOrDefault();
            if (ojbSV != null)
            {
                db.NhomDanhBaDbSet.Remove(ojbSV);

            }
            db.SaveChanges();
        }
        public static void Add(NhomDanhBa nhom)
        {
            var db = new KiemTraDBContext();
            db.NhomDanhBaDbSet.Add(nhom);
            db.SaveChanges();

        }
        public static List<NhomDanhBa> GetListFromDB()
        {
            return new KiemTraDBContext().NhomDanhBaDbSet.ToList();
        }
    }
}

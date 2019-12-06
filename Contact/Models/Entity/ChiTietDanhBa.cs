using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Models.Entity
{
    public class ChiTietDanhBa
    {
        [Key]
        public string Tengoi { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        [Key]
        public string SDT { get; set; }
        public string TenNhom { get; set; }
        [ForeignKey("TenNhom")]
        public virtual NhomDanhBa NhomDanhBa { get; set; }
        public static List<ChiTietDanhBa> GetListFromDB(string Tennhom)
        {
            return new KiemTraDBContext().ChiTietDanhBaDbSet.Where(e => e.TenNhom == Tennhom).ToList();
        }
        //aasdasd
        public static void Remove(ChiTietDanhBa ten)
        {
            var db = new KiemTraDBContext();
            var ojbSV = db.ChiTietDanhBaDbSet.Where(e => e.Tengoi == ten.Tengoi).FirstOrDefault();
            if (ojbSV != null)
            {
                db.ChiTietDanhBaDbSet.Remove(ojbSV);

            }
            db.SaveChanges();
        }
        public static void Add(ChiTietDanhBa nhom)
        {
            var db = new KiemTraDBContext();
            db.ChiTietDanhBaDbSet.Add(nhom);
            db.SaveChanges();

        }
    }
}

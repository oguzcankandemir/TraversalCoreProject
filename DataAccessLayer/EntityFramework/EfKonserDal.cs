using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfKonserDal : GenericRepository<Konser>, IKonserDal
    {
        public Konser GetKonserWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Konserlerim.Where(x => x.KonserID == id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Konser> GetLast4Konser()
        {
            using (var context = new Context())
            {
                var values = context.Konserlerim.Take(4).OrderByDescending(x => x.KonserID).ToList();
                return values;
            }
        }
    }
}

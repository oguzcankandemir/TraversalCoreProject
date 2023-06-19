using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IKonserDal:IGenericDal<Konser>
    {
        public Konser GetKonserWithGuide(int id);
        public List<Konser> GetLast4Konser();
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IKonserService:IGenericService<Konser>
    {
        public Konser TGetKonserWithGuide(int id);
        public List<Konser> TGetLast4Konserler();
        Task FindByNameAsync(Konser konser);
        Task GetKonserById(int konserID);
        object TGetByID(string konserID);
    }
}

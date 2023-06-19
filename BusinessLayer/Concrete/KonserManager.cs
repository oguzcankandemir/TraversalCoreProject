using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KonserManager : IKonserService
    {
        IKonserDal _konserDal;

        public KonserManager(IKonserDal konserDal)
        {
            _konserDal = konserDal;
        }

        public Task FindByNameAsync(Konser konser)
        {
            throw new NotImplementedException();
        }

        public Task GetKonserById(int konserID)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Konser t)
        {
            _konserDal.Insert(t);
        }

        public void TDelete(Konser t)
        {
            _konserDal.Delete(t);
        }

        public Konser TGetByID(int id)
        {
            return _konserDal.GetByID(id);
        }

        public object TGetByID(string konserID)
        {
            throw new NotImplementedException();
        }

        public Konser TGetKonserWithGuide(int id)
        {
            return _konserDal.GetKonserWithGuide(id);
        }

        public List<Konser> TGetLast4Konserler()
        {
            return _konserDal.GetLast4Konser();
        }

        public List<Konser> TGetList()
        {
            return _konserDal.GetList();
        }

        public void TUpdate(Konser t)
        {
            _konserDal.Update(t);
        }
    }
}

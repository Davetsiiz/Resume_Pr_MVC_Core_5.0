using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // T entity değeridir. T bir class a ait bütün değerleri üstüne alabilir o yüzden where T: class yapısı kullandık.
    public  interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);  
    }
}

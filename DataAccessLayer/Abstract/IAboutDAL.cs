using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //<about> bir entitydir bir değer dündürmesi için gereklidr. Aslında IGenericDal içinde T Değerine karşılık gelir.
    public interface IAboutDAL:IGenericDal<About>
    {
        //IGenericDal dan miras aldığımız için alttaki metodlara ihtiyaç kalmadı. 
        //void Insert(About p);
        //void Delete(About p);
        //void Update(About p);
        //List<About> GetList();
        
    }
}

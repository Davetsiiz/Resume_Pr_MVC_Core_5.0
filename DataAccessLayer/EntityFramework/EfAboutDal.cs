﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.EntityFramework
{
    //crud işlemleri dışında bir işlem yapılacaksa IAboutDal da yapılacağı için ekliyoruz.
    public class EfAboutDal : GenericRepository<About>, IAboutDAL
    {

    }
}

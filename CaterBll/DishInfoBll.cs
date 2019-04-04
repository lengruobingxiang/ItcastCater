﻿using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class DishInfoBll
    {
        DishInfoDal diDal = new DishInfoDal();

        public List<DishInfo> GetList(Dictionary<string, string> para)
        {
            return diDal.GetList(para);
        }

        public bool Add(DishInfo di)
        {
            return diDal.Insert(di) > 0;
        }

        public bool Edit(DishInfo di)
        {
            return diDal.Update(di) > 0;
        }

        public bool Remove(int id)
        {
            return diDal.Delete(id) > 0;
        }
    }
}

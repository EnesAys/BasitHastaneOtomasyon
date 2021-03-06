﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonLIB
{
   public interface IRepository<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemID);
        List<T> SelectAll();
        T SelectByID(int itemID);
    }
}

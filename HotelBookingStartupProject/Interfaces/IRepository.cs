﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingStartupProject.Interfaces
{
        public interface IRepository<T>
        {
            IEnumerable<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Edit(T entity);
            void Remove(int id);
        }
    
}

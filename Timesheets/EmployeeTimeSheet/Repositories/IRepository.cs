﻿using EmployeeTimeSheet.Models;
using System;
using System.Collections.Generic;

namespace EmployeeTimeSheet.Repositories
{
    public interface IRepository<T>
    {
        T GetItem(Guid id);
        T SearchByName(string name);
        IEnumerable<T> GetItems(int firstIndex, int itemsCount);
        void Add(T item);
        void Update(Person person);
        void Delete(Guid id);
    }
}

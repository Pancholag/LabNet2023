using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal interface IABMLogic<T, Tid>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Remove(Tid id);
        T Find(Tid id);
        void Update(T item);
        Tid GenerateId();
    }
}

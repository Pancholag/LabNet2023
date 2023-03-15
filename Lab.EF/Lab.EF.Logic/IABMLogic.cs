using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public interface IAbmLogic<T, Tid>
    {
        /// <summary>
        /// Devuelve una coleccion con los registros de la base de datos
        /// </summary>
        /// <returns>IEnumerable<T></returns>
        IEnumerable<T> GetAll();
        void Add(T item);
        T Remove(Tid id);
        T Find(Tid id);
        void Update(T item);
    }
}

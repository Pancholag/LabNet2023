using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic , IAbmLogic<Shipper, int>
    {
        public ShippersLogic() {}
        public ShippersLogic(NorthwindContext context)
        {
            _northWindContext = context;
        }
        public IEnumerable<Shipper> GetAll()
        {
            List<Shipper> list = _northWindContext.Shippers.ToList();
            if (list.Count == 0)
                throw new ArgumentException("No hay tranportistas en la base de datos");
            return list;
        }

        public void Add(Shipper item) 
        {
            if (_northWindContext.Shippers.
                FirstOrDefault(s => s.CompanyName == item.CompanyName) != null)
                throw new ArgumentException("Transportista ya registrado");

            _northWindContext.Shippers.Add(item);
            _northWindContext.SaveChanges();
        }

        public Shipper Remove(int id)
        {
            Shipper c = Find(id);
            _northWindContext.Shippers.Remove(c);
            _northWindContext.SaveChangesAsync();
            return c;
        }

        public Shipper Find(int id)
        {
            var shipper = _northWindContext.Shippers.FirstOrDefault(s => s.ShipperID == id);
            if (shipper == null)
                throw new ArgumentException($"Transportista con el id {id} no encontrado");
            return shipper;
        }

        public void Update(Shipper item)
        {
            var shipperToUpdate = Find(item.ShipperID);
            shipperToUpdate.CompanyName = item.CompanyName;
            _northWindContext.SaveChanges();
        }
    }
}

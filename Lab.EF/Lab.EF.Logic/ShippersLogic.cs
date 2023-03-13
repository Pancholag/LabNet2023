using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic : BaseLogic , IABMLogic<Shipper, int>
    {
        public IEnumerable<Shipper> GetAll()
        {
            return _northWindContext.Shippers.ToList();
        }

        public void Add(Shipper item) 
        {
            _northWindContext.Shippers.Add(item);
            _northWindContext.SaveChangesAsync();
        }

        public void Remove(int id)
        {
            Shipper c = Find(id);
            _northWindContext.Shippers.Remove(c);
            _northWindContext.SaveChangesAsync();
        }

        public Shipper Find(int id)
        {
            return _northWindContext.Shippers.FirstOrDefault(s => s.ShipperID == id);
        }

        public void Update(Shipper item)
        {
            var shipperToUpdate = _northWindContext.Shippers.FirstOrDefault(s => s.ShipperID == item.ShipperID);
            shipperToUpdate.CompanyName = item.CompanyName;
            _northWindContext.SaveChanges();
        }

        public int GenerateId()
        {
            int id = 0;

            foreach (var s in GetAll())
            {
                if (s.ShipperID >= id)
                    id = s.ShipperID + 1;
            }

            return id;
        }
    }
}

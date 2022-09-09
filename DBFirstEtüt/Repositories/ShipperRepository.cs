using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstEtüt.Repositories
{
    public class ShipperRepository
    {
        NorthwindEntities db = new NorthwindEntities();


        public List<Shipper> GetShippers()
        {
            return db.Shippers.ToList();
        }


    }




}

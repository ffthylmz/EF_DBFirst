using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstEtüt.Repositories
{
    public class OrderRepository
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public List<Order> GetOrdersByEmployeeID(int employeeID)
        {
            //select * from order where employeeıd=1

            return db.Orders.Where(o => o.EmployeeID == employeeID).ToList();
        }

        //OrderID ye göre getir.

        public Order GetOrderByID(int orderID)
        {
            return db.Orders.Find(orderID);
        }

        //ShipperID'ye göre getir.

        public List<Order> GetOrdersByShipperID(int shipperID)
        {
            return db.Orders.Where(o => o.ShipVia == shipperID).ToList();
        }

        public List<Order> GetOrderByEmployeeIDAndShipperID(int employeeId, int shipperId)
        {
            return db.Orders.Where(o => o.EmployeeID == employeeId && o.ShipVia == shipperId).ToList();
        }
        public Order AddOrder(Order order)
        {
            return db.Orders.Add(order);
        }

        public int AddOrder2(Order order)
        {
            db.Orders.Add(order);
            int rows = db.SaveChanges();
            return rows;
        }

        public int DeleteOrder(int orderID)
        {
            Order order = db.Orders.Find(orderID);
            db.Orders.Remove(order);
            int rows = db.SaveChanges();
            return rows;
        }

        public int UpdateOrder(Order order)
        {
            Order updatedOrder = db.Orders.Find(order.OrderID);
            updatedOrder.OrderDate = order.OrderDate;
            updatedOrder.ShipCity = order.ShipCity;
            updatedOrder.EmployeeID = order.EmployeeID;
            updatedOrder.ShipVia = order.ShipVia;
            int rows = db.SaveChanges();
            return rows;
        }

    }
}

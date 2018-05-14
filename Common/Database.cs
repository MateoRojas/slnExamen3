using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnExamen3.DTOs;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;

namespace slnExamen3.Common
{
    class Database
    {
        SQLiteConnection connection;

        public Database()
        {
            connection = new SQLiteConnection(new SQLitePlatformWinRT(), Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MyDatabase.sqlite"));
            connection.CreateTable<Client>();
            connection.CreateTable<Order>();
            connection.CreateTable<OrderProducts>();
            connection.CreateTable<Product>();
        }

        public void Insert(Object objecto)
        {
            connection.Insert(objecto);
        }

        public List<Client> getClients()
        {
            return connection.Table<Client>().ToList<Client>();
        }

        public List<Product> getProducts()
        {
            return connection.Table<Product>().ToList<Product>();
        }

        public List<OrderProducts> getOrderProducts(int orderId)
        {
            return connection.Table<OrderProducts>().Where(orderProduct => orderProduct.OrderId == orderId).ToList<OrderProducts>();
        }
    }
}

using BiletlemeSis.Models;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace BiletlemeSis.Repositories
{
    public class CustomerRepo
    {
        public Customer GetById(int id)
        {
            Customer _customer = new Customer();

            try
            {
                using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbModel"].ConnectionString))
                {
                    _customer = db.Get<Customer>(id);
                }
            }
            catch (Exception e)
            {
                _customer = null;
            }
            return _customer;
        }
        public long Insert(Customer _customer)
        {
            long sonuc = 0;
            try
            {
                using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbModel"].ConnectionString))
                {
                    sonuc = db.Insert(_customer);
                }
            }
            catch (Exception e)
            {
                sonuc = 0;
            }
            return sonuc;
        }
        public bool Update(Customer _customer)
        {
            bool sonuc = false;
            try
            {
                using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbModel"].ConnectionString))
                {
                    sonuc = db.Update(_customer);
                }
            }
            catch (Exception e)
            {
                sonuc = false;
            }
            return sonuc;
        }
        public bool Delete(Customer _customer)
        {
            bool sonuc = false;
            try
            {
                using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbModel"].ConnectionString))
                {
                    sonuc = db.Delete(_customer);
                }
            }
            catch (Exception e)
            {
                sonuc = false;
            }
            return sonuc;
        }
    }
}
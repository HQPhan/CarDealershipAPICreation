using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using CarDealershipAPICreation.Controllers;

namespace CarDealershipAPICreation
{
    public class CarsDAL
    {
        //public static List<Cars> GetCars()
        //{
        //    using (var connect = new MySqlConnection(Secret.Connection))
        //    {
        //        var sql = "select * from cars";
        //        connect.Open();
        //        List<Cars> cars = connect.Query<Cars>(sql).ToList();
        //        connect.Close();

        //        return cars;
        //    }
        //}
    }
}

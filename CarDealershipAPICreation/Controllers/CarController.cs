using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CarDealershipAPICreation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public static List<Cars> GetCars()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from cars";
                connect.Open();
                List<Cars> cars = connect.Query<Cars>(sql).ToList();
                connect.Close();

                return cars;
            }
        }

        [HttpGet]
        public List<Cars> GetAllCars()
        {
            return GetCars();
        }

        List<Cars> fordCars = GetCars().Where(x => x.make == "Ford").ToList();

        [HttpGet("Ford")]
        public List<Cars> GetFord()
        {
            return fordCars;
        }

        List<Cars> JeepCars = GetCars().Where(x => x.make == "Jeep").ToList();

        [HttpGet("Jeep")]
        public List<Cars> GetJeep()
        {
            return JeepCars;
        }

        List<Cars> DodgeCars = GetCars().Where(x => x.make == "Dodge").ToList();

        [HttpGet("Dodge")]
        public List<Cars> GetDodge()
        {
            return DodgeCars;
        }

        List<Cars> CatillacCars = GetCars().Where(x => x.make == "Catillac").ToList();

        [HttpGet("Catillac")]
        public List<Cars> GetCatillac()
        {
            return CatillacCars;
        }

        [HttpGet("GetCar/{index+1}")]
        public Cars GetCarByIndex(int index)
        {
            try
            {
                return GetCars()[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
    }
}

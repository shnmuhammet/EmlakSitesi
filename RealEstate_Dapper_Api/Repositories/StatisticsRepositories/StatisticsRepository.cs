
using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }
        public int ActiveCategoryCount()
        {
            string query = "select Count(*) from Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values =connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "select Count(*) from Employee where Status=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "select Count(*) from Product where Title like'%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AvgProductPriceByRent()
        {
            string query = "select AVG(Price) from Product where Type='Kiralık'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AvgProductPriceBySale()
        {
            string query = "select AVG(Price) from Product where Type='Satılık'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public string AvgRoomCount()
        {
            string query = "select AVG(RoomCount) from ProductDetails";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int CategoryCount()
        {
            string query = "select COUNT(*) from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "select top(1) CategoryName,count(*) from product inner join Category on Product.ProductCategory=Category.CategoryID group by CategoryName order by count(*) desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string CityNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public int DiffrentCityCount()
        {
            throw new NotImplementedException();
        }

        public string EmployeeNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public decimal lastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }
    }
}

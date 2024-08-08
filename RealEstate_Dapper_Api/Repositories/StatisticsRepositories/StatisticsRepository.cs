
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
            string query = "select top(1) city,COUNT(*) as 'ilan sayısı' from Product group by City order by [ilan sayısı] desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int DiffrentCityCount()
        {
            string query = "select count(distinct(City)) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "select Name ,Count(*) 'ilan sayisi' from Product\tinner join Employee on Product.EmployeeID=Employee.EmployeeID group by Name order by [ilan sayisi] desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public decimal lastProductPrice()
        {
            string query = "select Top(1) Price From Product order by ProductId Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "select top(1) BuildYear from ProductDetails order by BuildYear desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "select top(1) BuildYear from ProductDetails order by BuildYear asc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int PassiveCategoryCount()
        {
            string query = "select count(*) from Category where CategoryStatus=0";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "select count(*) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}

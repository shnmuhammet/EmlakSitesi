using Dapper;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_UI.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async void CreatePopularLocation(CreatePopularLocationDto createPopularLocation)
        {
            string query = "insert into PopularLocation (CityName,ImageUrl) values (@cityname,@imageurl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityname", createPopularLocation.CityName);
            parameters.Add("@imageurl", createPopularLocation.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {
            string query = "Delete from PopularLocation where LocationID=@LocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@LocationID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "select*from PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select*From PopularLocation where LocationID=@LocationID";
            var parameters = new DynamicParameters();
            parameters.Add("@LocationID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetPopularLocationDto>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDto UpdatePopularLocation)
        {
            string query = "update PopularLocation set CityName=@cityName,ImageUrl=@imageurl where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", UpdatePopularLocation.CityName);
            parameters.Add("@imageurl", UpdatePopularLocation.ImageUrl);
            parameters.Add("@locationID", UpdatePopularLocation.LocationID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }


    }
}

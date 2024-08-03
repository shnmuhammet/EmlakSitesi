using Dapper;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }
        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title,SubTitle,Description1,Description2) values (@title,@subTitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title",createWhoWeAreDetailDto.Title);
            parameters.Add("@subTitle",createWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete from WhoWeAreDetail where WhoWeAreDetailID=@DetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@DetailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "select*from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {
            string query = "Select*From WhoWeAreDetail where WhoWeAreDetailID=@DetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@DetailID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto whoWeAreDetailDto)
        {
            string query = "update WhoWeAreDetail set Title=@title,SubTitle=@subTitle,Description1=@dsc1,Description2=@dsc2 where WhoWeAreDetailID=@wvID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetailDto.Title);
            parameters.Add("@subTitle", whoWeAreDetailDto.Subtitle);
            parameters.Add("@dsc1", whoWeAreDetailDto.Description1);
            parameters.Add("@dsc2", whoWeAreDetailDto.Description2);
            parameters.Add("@wvID", whoWeAreDetailDto.WhoWeAreDetailID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

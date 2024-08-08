using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategorycount()
        {
            return Ok(_statisticsRepository.ActiveCategoryCount());
        }
        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticsRepository.ActiveEmployeeCount());
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsRepository.ApartmentCount());
        }
        [HttpGet("AvgProductPriceByRent")]
        public IActionResult AvgProductPriceByRent()
        {
            return Ok(_statisticsRepository.AvgProductPriceByRent());
        }
        [HttpGet("AvgProductPriceBySale")]
        public IActionResult AvgProductPriceBySale()
        {
            return Ok(_statisticsRepository.AvgProductPriceBySale());
        }
        [HttpGet("AvgRoomCount)")]
        public IActionResult AvgRoomCount()
        {
            return Ok(_statisticsRepository.AvgRoomCount());
        }
        [HttpGet("CategoryCount)")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticsRepository.CategoryCount());
        }
        [HttpGet("CategoryNameByMaxProductCount)")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CategoryNameByMaxProductCount());
        }
        [HttpGet("CityNameByMaxProductCount)")]
        public IActionResult CityNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CityNameByMaxProductCount());
        }
        [HttpGet("DiffrentCityCount)")]
        public IActionResult DiffrentCityCount()
        {
            return Ok(_statisticsRepository.DiffrentCityCount());
        }
        [HttpGet("EmployeeNameByMaxProductCount)")]
        public IActionResult EmployeeNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.EmployeeNameByMaxProductCount());
        }
        [HttpGet("lastProductPrice)")]
        public IActionResult lastProductPrice()
        {
            return Ok(_statisticsRepository.lastProductPrice());
        }
        [HttpGet("NewestBuildingYear)")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticsRepository.NewestBuildingYear());
        }
        [HttpGet("OldestBuildingYear)")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticsRepository.OldestBuildingYear());
        }
        [HttpGet("PassiveCategoryCount)")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticsRepository.PassiveCategoryCount());
        }
        [HttpGet("ProductCount)")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticsRepository.ProductCount());
        }

    }
}

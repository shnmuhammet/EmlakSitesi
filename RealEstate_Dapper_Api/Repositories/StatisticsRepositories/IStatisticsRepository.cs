﻿namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AvgProductByRent();
        decimal AvgProductBySale();
        string CityNameByMaxProductCount();
        int DiffrentCityCount();
        decimal lastProductPrice();
        string NewestBuildingYear(); 
        string OldestBuildingYear(); 
        string AvgRoomCount();
        int ActiveEmployeeCount();

        
    }
}

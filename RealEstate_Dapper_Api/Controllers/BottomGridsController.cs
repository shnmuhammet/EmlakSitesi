﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult>GetBottomGridList()
        {
            var value=await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(value) ;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDto);
            return Ok("Veri başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Veri başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpadeteBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
            return Ok("Veri Güncelledni");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }
    }
}

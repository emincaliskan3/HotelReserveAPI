﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAppUser(AppUser appUser)
        {
            _appUserService.TInsert(appUser);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAppUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAppUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAppUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            return Ok(values);
        }
    }
}

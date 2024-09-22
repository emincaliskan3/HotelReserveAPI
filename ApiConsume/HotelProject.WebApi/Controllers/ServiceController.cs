﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService serviceService)
        {
            _servicesService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _servicesService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _servicesService.TInsert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _servicesService.TGetByID(id);
            _servicesService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _servicesService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _servicesService.TGetByID(id);
            return Ok(values);
        }
    }
}

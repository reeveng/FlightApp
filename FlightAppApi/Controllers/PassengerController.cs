﻿using FlightAppApi.DTO;
using FlightAppApi.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightAppApi.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerRepository _passengerRepository;
        private readonly IProductRepository _productRepository;

        public PassengerController(IPassengerRepository passengerRepo, IProductRepository productRepository)
        {
            _passengerRepository = passengerRepo;
            _productRepository = productRepository;
        }

        /// <summary>
        /// Get the current passenger
        /// </summary>        
        [HttpGet]
        public ActionResult<Passenger> GetPassenger()
        {
            Passenger passenger = _passengerRepository.GetPassengerByEmail(User.Identity.Name);
            return passenger;
        }

        /// <summary>
        /// Add products to the current passenger
        /// </summary>        
        [HttpPost("/api/products/")]
        public ActionResult<List<ProductDTO>> OrderProducts(List<ProductDTO> products)
        {
            Passenger passenger = _passengerRepository.GetPassengerByEmail(User.Identity.Name);
            Order order = new Order();
            foreach (ProductDTO productDTO in products)
            {
                Product product = _productRepository.GetProductByName(productDTO.Name);
                order.Orderlines.Add(new Orderline(product));

            }
            passenger.Orders.Add(order);
            _passengerRepository.SaveChanges();
            _productRepository.SaveChanges();
            return products;

        }
    }
}

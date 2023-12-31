﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAPIcorreo.Sevices;
using PruebaAPIcorreo.Models;


namespace PruebaAPIcorreo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailServices _emailServices;

        public EmailController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDTO request)
        {
            _emailServices.SendEmail(request);
            return Ok();
        }

    }
}
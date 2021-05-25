﻿using LoginApi.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Controllers
{
    [Route("apiLogin/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult login(LoginViewModels loginViewModel) 
        {
            return Ok(loginViewModel);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult register(RegisterViewModels loginViewModel)
        {
            return Created("", loginViewModel);
        }
    }
}

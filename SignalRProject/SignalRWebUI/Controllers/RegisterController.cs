﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.Dtos.IdentityDtos;

namespace SignalRWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost,AllowAnonymous]
        public async Task <IActionResult> Index(RegisterDto registerDto)
        {
            var appUser = new AppUser()
            {
                Name=registerDto.Name,
                Surname=registerDto.SurName,
                Email=registerDto.UserName,
                UserName=registerDto.UserName
            };
            var result=await _userManager.CreateAsync(appUser,registerDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}

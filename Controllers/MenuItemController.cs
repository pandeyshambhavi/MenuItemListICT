using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2019,01,01), FreeDelivery=false,Price=200},
                new MenuItem() {Id=2, Name="shakes", Active=false, DateOfLaunch=new DateTime(2020,10,03), FreeDelivery=false,Price=100},
                new MenuItem() {Id=3, Name="Biriyani", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false,Price=200}
               
            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2019,01,01), FreeDelivery=false,Price=200},
                new MenuItem() {Id=2, Name="shakes", Active=false, DateOfLaunch=new DateTime(2020,10,03), FreeDelivery=false,Price=100},
                new MenuItem() {Id=3, Name="Biriyani", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false,Price=200}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }

    }
}

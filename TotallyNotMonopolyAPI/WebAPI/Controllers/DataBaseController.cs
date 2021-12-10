using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Persistence;
using Model;
using Services;

namespace WebAPI.Controllers
{
    public class DataBaseController : Controller
    {
        DataBaseService dataBaseService = new DataBaseService();
        public Ranking LoadRanking()
        {
            return dataBaseService.GetRanking();
        }

    }
}

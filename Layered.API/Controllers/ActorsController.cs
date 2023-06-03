using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layered.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Layered.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        public IUnitOfWork _unitofwork { get; }
        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_unitofwork.Actor.GetAll());
        }
        [HttpGet("movies")]
        public ActionResult GetByMovies()
        {
            return Ok(_unitofwork.Actor.GetActorByMovies());
        }
    }
}
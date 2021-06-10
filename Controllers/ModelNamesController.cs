using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProjectNamesController : ControllerBase
    {
        private readonly ApiTemplateContext _db;

        public ProjectNamesController(ApiTemplateContext db)
        {
            _db = db; 
        }
    }

}

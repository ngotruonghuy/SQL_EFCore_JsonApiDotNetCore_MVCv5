using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Configuration;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Services;

namespace ContosoUniversity.Controllers
{
    public class DepartmentsController : JsonApiController<Department>
    {
        public DepartmentsController(
            IJsonApiOptions options, 
            ILoggerFactory loggerFactory,
            IResourceService<Department, int> resourceService) 
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}

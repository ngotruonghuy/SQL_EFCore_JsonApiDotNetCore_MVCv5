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

namespace ContosoUniversity
{
    public class StudentsController : JsonApiController<Student>
    {
        public StudentsController(
            IJsonApiOptions options,
            ILoggerFactory loggerFactory,
            IResourceService<Student, int> resourceService) 
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}

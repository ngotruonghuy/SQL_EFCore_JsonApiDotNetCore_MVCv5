using ContosoUniversity.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Configuration;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Services;

namespace ContosoUniversity.Controllers
{
    public class CoursesController : JsonApiController<Course>
    {
        public CoursesController(
            IJsonApiOptions options,
            ILoggerFactory loggerFactory,
            IResourceService<Course, int> resourceService)
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}

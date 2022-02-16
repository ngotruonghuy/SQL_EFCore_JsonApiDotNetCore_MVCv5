using ContosoUniversity.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Configuration;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Services;

namespace ContosoUniversity.Controllers
{
    public class InstructorsController : JsonApiController<Instructor>
    {
        public InstructorsController(
            IJsonApiOptions options,
            ILoggerFactory loggerFactory,
            IResourceService<Instructor, int> resourceService) 
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}

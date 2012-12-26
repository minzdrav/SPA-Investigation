using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamper.Data.Contracts;
using CodeCamper.Model;

namespace CodeCamper.Web.Controllers
{

    public abstract class ApiControllerBase : ApiController
    {
        protected ICodeCamperUow Uow { get; set; }
    }

    public class SpeakersController : ApiControllerBase
    {

        public SpeakersController(ICodeCamperUow uow)
        {
            Uow = uow;
        }

        // GET api/speakers
        public IEnumerable<Speaker> Get()
        {
            return Uow.Persons.GetSpeakers().OrderBy(s => s.FirstName);
        }
    }
}

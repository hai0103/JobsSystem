using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;

namespace JobsSystem.Controllers
{
    //[RoutePrefix("/api")]
    public class CandidateController : ApiController
    {
        private JobsSystemContext db = new JobsSystemContext();

        //[Route("api/candidate")]
        [HttpGet]
        public List<Candidate> GetAll()
        {
            return db.Candidates.ToList();
        }
    }
}

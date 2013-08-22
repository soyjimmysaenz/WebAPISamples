﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingWebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        // GET api/values/1
        public string Get(int id)
        {
            return "default value";
        }

        // GET api/values/bydoctor/1
        [HttpGet]
        [ActionName("ByDoctor")]
        public string ByDoctor(int id)
        {
            return "value by doctor";
        }

        // GET api/values/byassistant/1
        [HttpGet]
        [ActionName("ByAssistant")]
        public string ByAssistant(int id)
        {
            return "value by assistant";
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]string value)
        {
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;
        }

        // PUT api/values/1
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        // DELETE api/values/1
        public HttpResponseMessage Delete(int id)
        {
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            return response;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using BeerCellar.Models;
using BeerCellar.DataAccess;
using Newtonsoft.Json.Linq;

namespace BeerCellar.Controllers
{
    [Route("api/graphql")]
    public class GraphQLController : Controller
    {
        private readonly IDocumentExecuter _exec;
        private readonly BeerCellarQuery _query;

        public GraphQLController(
            IDocumentExecuter exec,
            BeerCellarQuery query)
        {
            _exec = exec;
            _query = query;
        }

        [HttpGet]
        public async Task<JsonResult> Get(
            string query,
            string variables = null,
            string operationName = null)
        {
            var result = await _exec.ExecuteAsync(x =>
            {
                x.Schema = new Schema { Query = _query };
                x.Query = query;
            });
            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] GraphQLQuery query)
        {
            var result = await _exec.ExecuteAsync(x =>
            {
                x.Schema = new Schema { Query = _query };
                x.Query = query.Query;
            });
            return new JsonResult(result);
        }
    }
}

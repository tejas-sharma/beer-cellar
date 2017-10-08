using System;
using Newtonsoft.Json.Linq;

namespace BeerCellar.Models
{
    public class GraphQLQuery
    {
        public GraphQLQuery()
        {
        }

        public string Query { get; set; }
        public string OperationName { get; set; }
        public JObject Variables { get; set; }
    }
}

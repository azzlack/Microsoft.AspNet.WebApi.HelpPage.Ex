using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Microsoft.AspNet.WebApi.HelpPage.Controllers
{
    using System.Web.Http.Description;

    using Microsoft.AspNet.WebApi.HelpPage.Models;

    /// <summary>
    /// Endpoint for interacting with values.
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Gets all values.
        /// </summary>
        /// <returns>A list of values.</returns>
        public IEnumerable<Value> Get()
        {
            return new[] { new Value("value1"), new Value("value2") };
        }

        /// <summary>
        /// Gets the value with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The value.</returns>
        [ResponseType(typeof(Value))]
        public HttpResponseMessage Get(int id)
        {
            return this.Request.CreateResponse(new Value());
        }

        /// <summary>
        /// Adds the specified <see cref="Value"/> to the database.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>201 Created</c> of successful, an error code if not.</returns>
        [Authorize]
        public HttpResponseMessage Post(Value value)
        {
            return this.Request.CreateResponse(HttpStatusCode.Created);
        }

        /// <summary>
        /// Updates the value with the specified identifier using the provided <paramref name="value"/>.
        /// </summary>
        /// <param name="id">The value identifier.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>200 OK</c> of successful, an error code if not.</returns>
        [Authorize]
        public HttpResponseMessage Put(int id, Value value)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// Deletes the value with the specified identifier.
        /// </summary>
        /// <param name="id">The value identifier.</param>
        /// <returns><c>200 OK</c> of successful, an error code if not.</returns>
        /// <exception cref="System.Exception">Delete is not allowed</exception>
        [Authorize]
        public HttpResponseMessage Delete(int id)
        {
            throw new Exception("Delete is not allowed");
        }
    }
}

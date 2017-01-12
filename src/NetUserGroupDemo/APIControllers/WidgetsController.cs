using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetUserGroupDemo.Models;
using NetUserGroupDemo.Repository;

namespace NetUserGroupDemo.APIControllers
{
    [Route("api/[controller]")]
    public class WidgetsController : Controller
    {
        private readonly IDAL _dal;
        private readonly ILogger<WidgetsController> _logger;

        public WidgetsController(IDAL dal, ILogger<WidgetsController> logger)
        {
            _dal = dal;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Widget> Get()
        {
            _logger.LogError("In API::WidgetsController::Get Method");
            return new Widget[] { _dal.GetWidget()};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Widget Get(int id)
        {
            _logger.LogError($"In API::WidgetsController::Get by id Method: id = {id}");
            return _dal.GetWidget();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

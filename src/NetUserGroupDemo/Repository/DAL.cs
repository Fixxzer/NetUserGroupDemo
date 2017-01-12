using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NetUserGroupDemo.Models;

namespace NetUserGroupDemo.Repository
{
    public interface IDAL
    {
        Widget GetWidget();
    }

    public class DAL : IDAL
    {
        private readonly ILogger<DAL> _logger;

        public DAL(ILogger<DAL> logger)
        {
            _logger = logger;
        }

        public Widget GetWidget()
        {
            _logger.LogError("In DAL::GetWidget");
            return new Widget() {Id = 1, Name = "Widget 1", Price = 99.99m};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetUserGroupDemo.Models;
using NetUserGroupDemo.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NetUserGroupDemo.Controllers
{
    public class WidgetsController : Controller
    {
        private readonly IDAL _dal;
        private readonly ILogger<WidgetsController> _logger;
        private readonly MyOptions _options;

        public WidgetsController(IDAL dal, ILogger<WidgetsController> logger, IOptions<MyOptions> options)
        {
            _dal = dal;
            _logger = logger;
            _options = options.Value;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            _logger.LogError(_options.Option1);
            _logger.LogError("In WidgetsController::Index");
            var viewModel = _dal.GetWidget();
            return View(viewModel);
        }
    }
}

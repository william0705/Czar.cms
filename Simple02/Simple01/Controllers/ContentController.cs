using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Options;
using Simple01.Models;

namespace Simple01.Controllers
{
    public class ContentController : Controller
    {
        private Content _content { get; set; }

        public ContentController(IOptions<Content> options)
        {
            _content = options.Value;
        }

        public IActionResult Index()
        {
            
            return View(new ContentViewModel {Contents = new List<Content>(){ _content } });
        }
    }
}
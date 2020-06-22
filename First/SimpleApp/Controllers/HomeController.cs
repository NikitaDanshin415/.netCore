using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFile()
        {
            // Путь к файлу
            string file_path = Path.Combine("/App_Data/Introduction.pdf");
            // Тип файла - content-type
            string file_type = "application/pdf";
            // Имя файла - необязательно
            string file_name = "Introduction.pdf";
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}

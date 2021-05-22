using Microsoft.AspNetCore.Mvc;
using Sprint12.Models;
using Sprint12.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint12.Controllers
{
    public class TriangleController : Controller
    {
        private ITriangleService _triangleService;

        public TriangleController(ITriangleService triangleService)
        {
            _triangleService = triangleService;
            
        }
        public IActionResult Index()
        {
            
            ViewData["message"] = _triangleService.Area(10, 20, 25);
            return View();
        }

        public string Info(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            return $"Triangle: \n({side1}, {side2}, {side3}) \nReduced: \n({side1 / perimeter}, {side2 / perimeter}, {side3 / perimeter} \n \nArea = XX \nPerimeter = YY";
        }

        public double Area(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public double Perimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
        public bool IsRightAngled(double side1, double side2, double side3)
        {
            if(Math.Pow(side2, 2) == (Math.Pow(side1, 2) + Math.Pow(side3, 2)))
            {
                return true;
            }
            return false;
        }

        public bool IsEquilateral(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 == side3)
                return true;
            return false;
        }

        public bool IsIsosceles(double side1, double side2, double side3)
        {
            if(side1 == side3)
            {
                return true;
            }
            return false;
        }

        
        public bool aresimilar(Triangle tr1, Triangle tr2)
        {
            double p1 = tr1.side1 + tr1.side2 + tr1.side3;
            double p2 = tr2.side1 + tr2.side2 + tr2.side3;
            if (p2 % p1 == 0)
                return true;
            return false;
        }

    }
}

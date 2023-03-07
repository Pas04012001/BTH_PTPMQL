using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            ViewBag.message = strReturn;
            return View();
        }
        public IActionResult GiaPhuongTrinhBac2()
        {
            return View();
        }
        [HttpPost]
       public IActionResult GiaPhuongTrinhBac2(string hesoA, string hesoB, string hesoC)
        {
            //khai bao bien
            double delta, x1, x2, a = 0 , b = 0, c = 0;
            string ketqua;
            //giai phuong trinh bac 2
            if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
            if(!String.IsNullOrEmpty(hesoB)) a = Convert.ToDouble(hesoB);
            if(!String.IsNullOrEmpty(hesoC)) a = Convert.ToDouble(hesoC);
            if(a == 0) ketqua = "Khong phai phuong trinh bac 2";
            else
            {
                //tinhdelta
                delta = Math.Pow(b,2) - 4 * a * c;
                //giai phuong trinh
                if(delta < 0) ketqua = "Phuong trinh vo nghiem";
                else if(delta == 0)
                {
                    x1 = -b/(2*a);
                    ketqua = "Phuong trinh co nghiem kep = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta))/(2*a);
                    x2 = (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem: X1 = " + x1 + ", X2 = " + x2;
                }
            }
            ViewBag.message = ketqua;
            return View();
        }
    }
}
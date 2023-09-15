using Microsoft.AspNetCore.Mvc;
using TestBai2Banhang.Models.DanhSach;

namespace TestBai2Banhang.Controllers
{
    public class DanhSachController : Controller
    {
        public static List<ModelDanhSach> products = new List<ModelDanhSach>();
        public IActionResult Index(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            ViewData["ThongBao"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, double soluong, double dongia, double giamgia)
        {
            var homeProduct = new ModelDanhSach(tensanpham, soluong, dongia, giamgia);
            if (giamgia >= 100)
            {
                ViewData["ThongBao"] = "Giảm giá phải nhỏ hơn hoặc bằng 100";
            }
            else
            {
                products.Add(homeProduct);
            }
            return View(products);
        }


            public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dtl_lab04_bttl.Models;
using System.Xml.Linq;
using System.Xml;

namespace Dtl_lab04_bttl.Controllers
{
    public class DtlProductController : Controller
    {
        public ActionResult Index()
        {
            // Lấy đường dẫn tệp XML trong thư mục App_Data
            string filePath = HttpContext.Server.MapPath("~/App_Data/DtlProducts.xml");

            // Đọc dữ liệu từ tệp XML và chuyển đổi thành danh sách các đối tượng Product
            List<DtlProducts> products = DtlReadFromXmlFile(filePath);

            // Trả về view với danh sách sản phẩm
            return View(products);
        }

        private List<DtlProducts> DtlReadFromXmlFile(string filePath)
        {
            var products = new List<DtlProducts>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList productNodes = doc.SelectNodes("/Products/Product");

            foreach (XmlNode productNode in productNodes)
            {
                var product = new DtlProducts
                {
                    ProductId = productNode.SelectSingleNode("ProductId")?.InnerText,
                    ProductName = productNode.SelectSingleNode("ProductName")?.InnerText,
                    Unit = productNode.SelectSingleNode("Unit")?.InnerText,
                    Price = decimal.Parse(productNode.SelectSingleNode("Price")?.InnerText ?? "0")
                };

                products.Add(product);
            }
            return products;
        }

    }
}
using SEOURL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEOURL.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            List<New> myList = DummyNews();
            return View(myList);
        }

        public ActionResult Detail(string seoUrl)
        {
            New newDetail = DummyNews().Find(n => n.SeoUrl == seoUrl);
            return View(newDetail);
        }

        public List<New> DummyNews()
        {
            List<New> newsList = new List<New>();
            newsList.Add(new New { ID = 1, Title = "Van Persie Ayrıldı", Content = "Fenerbahce'de Robin Van Persie Hollanda'ya Transfer oldu", SeoUrl = "van-persie-hollanda-da" });
            newsList.Add(new New { ID = 2, Title = "Falcon Heavy Fırlatıldı", Content = "Elon Musk yine yaptı yapacağını..Falcon Heavy Uzayda.", SeoUrl = "falcon-heavy-firlatildi" });
            newsList.Add(new New { ID = 3, Title = "Endonezya sağlık bakanı istifa etti", Content = "Endonezya sağlık bakanı Endo Nezya görevi bıraktığını artık dayanamadığını açıkladı...=D", SeoUrl = "endonezya-saglik-bakani-birakti" });
            newsList.Add(new New { ID = 4, Title = "Bakın o ünlü ne yaptı", Content = "Ünlü Şarkıcı dün gece yediği yemeği kartla ödedi...", SeoUrl = "bakin-o-unlu-ne-yapti"});

            return newsList;
        }
    }
}
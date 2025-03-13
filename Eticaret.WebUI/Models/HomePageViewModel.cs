using Eticaret.Core.Entities;

namespace Eticaret.WebUI.Models
{
    public class HomePageViewModel
    {
        //sayfada birden fazla model kullanmamız gerektigi icin ekledik.

        public List<Slider>? Sliders{ get; set; }
        public List<Product>? Products{ get; set; }
        public List<News>? News { get; set; }


    }
}

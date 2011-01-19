using FubuMVC.Core.Continuations;
using FubuMVC.Core.Urls;

namespace TryFubu.Presentation.Controllers.Home
{
    public class HomeController
    {
        private readonly UrlRegistry _urls;

        public HomeController(UrlRegistry urls)
        {
            _urls = urls;
        }

        public FubuContinuation Index()
        {
            return FubuContinuation.TransferTo<HomeController>(c => c.Home(new HomeInputModel()));
        }

        public FubuContinuation Index2()
        {
            return FubuContinuation.RedirectTo(_urls.UrlFor<HomeController>(c => c.Home(new HomeInputModel())));
        }

        public HomeViewModel Home(HomeInputModel model)
        {
            return new HomeViewModel { Text = "Hello, world." };
        }
    }
}
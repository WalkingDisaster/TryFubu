using System.Web;

namespace TryFubu.Presentation.Services
{
    public class CurrentHttpContextSession : IHttpSession
    {
        public void Clear()
        {
            HttpContext.Current.Session.Clear();
        }

        public object this[string key]
        {
            get { return HttpContext.Current.Session[key]; }
            set { HttpContext.Current.Session[key] = value; }
        }
    }
}
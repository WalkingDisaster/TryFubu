using TryFubu.Presentation.Controllers.Home.Hello;

namespace TryFubu.Presentation.Controllers.Home
{
    public class HomeController
    {
        public HelloOutputModel QueryHello()
        {
            return new HelloOutputModel();
        }

        public HelloOutputModel HelloCommand(HelloInputModel model)
        {
            return new HelloOutputModel
                       {
                           Name = model.Name
                       };
        }
    }
}
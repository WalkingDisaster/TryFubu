using FubuMVC.Core;
using TryFubu.Presentation.Controllers.Home.Hello;

namespace TryFubu.Presentation.Configuration
{
    public class TryFubuRegistry : FubuRegistry
    {
        public TryFubuRegistry()
        {
            IncludeDiagnostics(true);

            HomeIs<HelloInputModel>();

            Actions
                .IncludeClassesSuffixedWithController();

            Routes
                .IgnoreControllerNamespaceEntirely()
                .IgnoreMethodSuffix("Command")
                .IgnoreMethodSuffix("Query")
                .ConstrainToHttpMethod(action => action.Method.Name.EndsWith("Command"), "POST")
                .ConstrainToHttpMethod(action => action.Method.Name.StartsWith("Query"), "GET");


            Views
                .TryToAttachWithDefaultConventions();

            HtmlConvention<TryFubuConventions>();
        }
    }
}
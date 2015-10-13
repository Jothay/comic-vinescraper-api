namespace ComicVineScraper.API.Services
{
    using System;
    using System.Configuration;
    using ServiceStack;
    using ServiceStack.Api.Swagger;

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var appHost = new AppHost();
            appHost.Plugins.Add(new SessionFeature());
            appHost.Plugins.Add(new SwaggerFeature());
#if DEBUG
            // Allow cross-site scripting for stand-alone development
            appHost.Plugins.Add(new CorsFeature(
                allowedMethods: "GET, POST, OPTIONS",
                allowedHeaders: "Origin, X-Requested-With, Content-Type, Accept, X-ApiKey, X-ss-pid, X-ss-opt"));
#endif
            appHost.GlobalRequestFilters.Add(
                (req, res, dto) => {
                    var localBypass = false;
#if DEBUG
                    localBypass = req.IsLocal;
#endif
                    if (localBypass) return;
                    var attr = dto.GetType().GetCustomAttributes(typeof(AuthenticateAttribute), false);
                    if (attr.Length <= 0) return;
                    var apiKey = req.Headers["X-ApiKey"] ?? req.GetParam("X-ApiKey");
                    if (apiKey == null || apiKey != ConfigurationManager.AppSettings["APIKey"])
                    {
                        throw HttpError.Unauthorized("Unauthorized");
                    }
                });
            typeof(Resources).AddAttributes(new RestrictAttribute { VisibilityTo = RequestAttributes.None });
            typeof(ResourceRequest).AddAttributes(new RestrictAttribute { VisibilityTo = RequestAttributes.None });
            appHost.Init();
        }
    }
}
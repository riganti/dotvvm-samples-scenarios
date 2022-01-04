using DotVVM.Framework.Configuration;
using DotVVM.Framework.Controls;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
using Microsoft.Extensions.DependencyInjection;
using Scenarios.Controls;

namespace Scenarios
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);

            config.Styles.Register<TextBox>().AddClass("form-control");
            config.Styles.Register<ComboBox>().AddClass("form-control");
            config.Styles.Register<CheckBox>().AddClass("form-check-input");

            config.Security.FrameOptionsSameOrigin.EnableForAllRoutes();
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/Default.dothtml");
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
            config.Markup.AddCodeControls("cc", typeof(CodeView));
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register("bootstrap", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/bootstrap/css/bootstrap.min.css"),
                Dependencies = new [] { "bootstrap-js" }
            });
            config.Resources.Register("bootstrap-js", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/bootstrap/js/bootstrap.bundle.min.js"),
                Dependencies = new [] { "jquery" }
            });
            config.Resources.Register("jquery", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/jquery/jquery.min.js")
            });
        }

		public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("temp");
            options.AddHotReload();
		}
    }
}

using System.IO;
using System.Linq;
using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;

namespace Scenarios.Controls
{
    public class SampleView : CompositeControl 
    {

        public DotvvmControl GetContents(
            string folder, 
            IDotvvmRequestContext context)
        {
            var viewsFolder = Path.Combine(context.Configuration.ApplicationPhysicalPath, "Views", folder);
            var viewModelsFolder = Path.Combine(context.Configuration.ApplicationPhysicalPath, "ViewModels", folder);

            var viewName = Path.GetFileNameWithoutExtension(Directory.GetFiles(viewsFolder, "*.dothtml").Single());

            var csharpFiles = Directory.GetFiles(viewModelsFolder, "*.cs")
                .Select(Path.GetFileNameWithoutExtension)
                .OrderBy(i => i.EndsWith("ViewModel") ? 0 : 1)
                .ThenBy(i => i)
                .ToList();


            return new HtmlGenericControl("div")
                .AddCssClass("row")
                .AppendChildren(
                    
                    new HtmlGenericControl("div")
                        .AddCssClass("col-xl-4")
                        .AppendChildren(
                            new HtmlGenericControl("div")
                                .AddCssClasses("embed-responsive", "embed-responsive-16by9")
                                .AppendChildren(
                                    new HtmlGenericControl("iframe")
                                        .AddAttribute("src", folder + "/" + viewName)
                                )
                        ),

                    new HtmlGenericControl("div")
                        .AddCssClass("col-xl-4")
                        .AppendChildren(
                            new CodeView()
                                .SetProperty("FileName", ValueOrBinding<string>.FromBoxedValue($"Views/{folder}/{viewName}.dothtml"))
                        ),

                    new HtmlGenericControl("div")
                        .AddCssClass("col-xl-4")
                        .AppendChildren(
                            new HtmlGenericControl("ul")
                                .AddCssClasses("nav", "nav-tabs")
                                .AddAttribute("role", "tablist")
                                .AppendChildren(
                                    csharpFiles.Select((file, index) => 
                                        new HtmlGenericControl("li")
                                            .AddCssClass("nav-item")
                                            .AddAttribute("role", "tabpanel")
                                            .AppendChildren(
                                                new HtmlGenericControl("a")
                                                    .AddCssClasses(index == 0 ? new[] { "nav-link", "active" } : new [] { "nav-link" })
                                                    .AddAttribute("href", $"#{folder}{index}")
                                                    .AddAttribute("role", "tab")
                                                    .AddAttribute("data-toggle", "tab")
                                                    .SetProperty(l => l.InnerText, file + ".cs")
                                            )
                                    )
                                ),
                            new HtmlGenericControl("div")
                                .AddCssClass("tab-content")
                                .AppendChildren(
                                    csharpFiles.Select((file, index) =>
                                        new HtmlGenericControl("div")
                                            .AddCssClasses(index == 0 ? new[] { "tab-pane", "active" } : new[] { "tab-pane" })
                                            .AddAttribute("role", "tabpanel")
                                            .SetProperty(c => c.ID, $"{folder}{index}")
                                            .AppendChildren(
                                                new CodeView()
                                                    .SetProperty("FileName", ValueOrBinding<string>.FromBoxedValue($"ViewModels/{folder}/{file}.cs"))
                                            )
                                    )
                                )
                        )
                );
        }

    }
}

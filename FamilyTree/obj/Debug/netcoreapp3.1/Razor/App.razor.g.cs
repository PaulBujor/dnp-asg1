#pragma checksum "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7fa65f9b7c51f3f4877e42977a25f3034a5d8d"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyTree
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using FamilyTree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/_Imports.razor"
using FamilyTree.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(13);
                    __builder3.AddAttribute(14, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "/Users/Claudia/Documents/VIA_UC/3rd_Semester/DNP1/Handin1/dnp-asg1/FamilyTree/App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "\n                ");
                        __builder4.AddMarkupContent(17, "<p>Sorry, there\'s nothing at this address.</p>\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

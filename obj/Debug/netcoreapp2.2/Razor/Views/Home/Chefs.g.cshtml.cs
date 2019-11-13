#pragma checksum "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa06e4143531461726276f1a47637df35327c1f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chefs), @"mvc.1.0.view", @"/Views/Home/Chefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Chefs.cshtml", typeof(AspNetCore.Views_Home_Chefs))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa06e4143531461726276f1a47637df35327c1f8", @"/Views/Home/Chefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 606, true);
            WriteLiteral(@"

<div class=""row mt-4"">
  <div class=""col offset-md-4"">
    <span>
      <h2>Chefs | <span><a href=""dishes"">Dishes</a></h2>
  </div>
  <div class=""col align-self-center text-center"">
    <a href=""new"">Add a Chef</a>
  </div>
</div>
<div class=""row"">
  <div class=""col mt-5 mb-2"">
    <h3>Check out our roster of Chefs!</h3>
  </div>
</div>
<div class=""row"">
  <div class=""col-10"">
    <table class=""table table-striped"">
      <thead>
        <tr>
          <th scope=""col"">Name</th>
          <th scope=""col"">Age</th>
          <th scope=""col""># of Dishes</th>
        </tr>
      </thead>
      <tbody>
");
            EndContext();
#line 28 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
         for(int i = Model.Count-1; i >= 0; i--)
        {

#line default
#line hidden
            BeginContext(665, 33, true);
            WriteLiteral("          <tr>\n              <td>");
            EndContext();
            BeginContext(699, 18, false);
#line 31 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
             Write(Model[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(717, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(719, 17, false);
#line 31 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
                                 Write(Model[i].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(736, 24, true);
            WriteLiteral("</td>\n              <td>");
            EndContext();
            BeginContext(761, 12, false);
#line 32 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
             Write(Model[i].Age);

#line default
#line hidden
            EndContext();
            BeginContext(773, 24, true);
            WriteLiteral("</td>\n              <td>");
            EndContext();
            BeginContext(798, 28, false);
#line 33 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
             Write(Model[i].CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(826, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 35 "/Users/dave/codingDojo/C#_stack/ORM/ChefsNDishes/Views/Home/Chefs.cshtml"
        }

#line default
#line hidden
            BeginContext(860, 43, true);
            WriteLiteral("      </tbody>\n    </table>\n  </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dfee3fa85066683c13ae1f880046f5792ccf763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Index.cshtml", typeof(AspNetCore.Views_Game_Index))]
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
#line 1 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\_ViewImports.cshtml"
using GameStore;

#line default
#line hidden
#line 2 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dfee3fa85066683c13ae1f880046f5792ccf763", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd522b5d11be77ad5cef1f1a50a2a9e5539791e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Game>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(60, 372, true);
            WriteLiteral(@"
<h1>Game Store</h1>

<div>
    <button class=""add-new"" onclick=""location.href='Game/Create'"">Create New Game</button>
</div>

<section>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>DLC</th>
                <th>Price</th>
                <th>Platform</th>
                <th>Actions</th>
            </tr>
");
            EndContext();
#line 22 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
             foreach (var game in Model)
            {

#line default
#line hidden
            BeginContext(489, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(528, 9, false);
#line 25 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
               Write(game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(537, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(565, 8, false);
#line 26 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
               Write(game.Dlc);

#line default
#line hidden
            EndContext();
            BeginContext(573, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(601, 10, false);
#line 27 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
               Write(game.Price);

#line default
#line hidden
            EndContext();
            BeginContext(611, 29, true);
            WriteLiteral(" $</td>\r\n                <td>");
            EndContext();
            BeginContext(641, 13, false);
#line 28 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
               Write(game.Platform);

#line default
#line hidden
            EndContext();
            BeginContext(654, 56, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 710, "\"", 754, 3);
            WriteAttributeValue("", 720, "location.href=\'Game/Edit/", 720, 25, true);
#line 30 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
WriteAttributeValue("", 745, game.Id, 745, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 753, "\'", 753, 1, true);
            EndWriteAttribute();
            BeginContext(755, 56, true);
            WriteLiteral(" class=\"edit\">Edit</button>\r\n                    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 811, "\"", 857, 3);
            WriteAttributeValue("", 821, "location.href=\'Game/Delete/", 821, 27, true);
#line 31 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
WriteAttributeValue("", 848, game.Id, 848, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 856, "\'", 856, 1, true);
            EndWriteAttribute();
            BeginContext(858, 75, true);
            WriteLiteral(" class=\"delete\">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Pepi\Desktop\Tech Module Exercises\TechFundamentalsFinalExam-20.12.2018\Web Problem\GameStore\Views\Game\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(948, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591

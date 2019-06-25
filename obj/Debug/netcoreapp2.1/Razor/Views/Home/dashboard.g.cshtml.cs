#pragma checksum "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a75b91167a977bbf95c2f9ccddafef9058c29c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dashboard), @"mvc.1.0.view", @"/Views/Home/dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dashboard.cshtml", typeof(AspNetCore.Views_Home_dashboard))]
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
#line 1 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/_ViewImports.cshtml"
using belt1;

#line default
#line hidden
#line 1 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
using belt1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a75b91167a977bbf95c2f9ccddafef9058c29c8", @"/Views/Home/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda17ae26909a3380933a6f4840560ccf17714ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Display>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 355, true);
            WriteLiteral(@"
<h3>Welcome to Dojo Activity Center</h3>

<table classs=""table"">
	<thead>
        <tr>
		<th scope=""col"">Activity</th>
		<th scope=""col"">Date & Time</th>
		<th scope=""col"">Duration</th>
        <th scope=""col"">Event Coordinator</th>
        <th scope=""col"">No of Participants</th>
        <th scope=""col"">Actions</th>
        </tr>
	</thead>
    <tbody>
");
            EndContext();
#line 18 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
     foreach (Display i in Model)
	{

#line default
#line hidden
            BeginContext(430, 16, true);
            WriteLiteral("\t\t<tr>\n\t\t\t<td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 446, "\"", 475, 2);
            WriteAttributeValue("", 453, "/activity/", 453, 10, true);
#line 21 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 463, i.DisplayID, 463, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(476, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(478, 14, false);
#line 21 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                                            Write(i.ActivityName);

#line default
#line hidden
            EndContext();
            BeginContext(492, 13, true);
            WriteLiteral("</td>\n\t\t\t<td>");
            EndContext();
            BeginContext(506, 20, false);
#line 22 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
           Write(i.Date.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(526, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(530, 6, false);
#line 22 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                                   Write(i.Time);

#line default
#line hidden
            EndContext();
            BeginContext(536, 23, true);
            WriteLiteral(" </td>\n            <td>");
            EndContext();
            BeginContext(560, 10, false);
#line 23 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
           Write(i.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(570, 23, true);
            WriteLiteral(" </td>\n            <td>");
            EndContext();
            BeginContext(594, 10, false);
#line 24 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
           Write(i.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(604, 14, true);
            WriteLiteral(" </td>\n\t\t\t<td>");
            EndContext();
            BeginContext(619, 16, false);
#line 25 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
           Write(i.Guests.Count());

#line default
#line hidden
            EndContext();
            BeginContext(635, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 27 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                 if (i.IsHosting)
                {

#line default
#line hidden
            BeginContext(710, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 728, "\"", 755, 2);
            WriteAttributeValue("", 735, "/delete/", 735, 8, true);
#line 29 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 743, i.DisplayID, 743, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(756, 30, true);
            WriteLiteral(">Delete</a>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 786, "\"", 811, 2);
            WriteAttributeValue("", 793, "/edit/", 793, 6, true);
#line 30 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 799, i.DisplayID, 799, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(812, 10, true);
            WriteLiteral(">Edit</a>\n");
            EndContext();
#line 31 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                }
                else if (!i.IsAttending)
                {

#line default
#line hidden
            BeginContext(899, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 917, "\"", 942, 2);
            WriteAttributeValue("", 924, "/join/", 924, 6, true);
#line 34 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 930, i.DisplayID, 930, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 35 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1010, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1054, 2);
            WriteAttributeValue("", 1035, "/leave/", 1035, 7, true);
#line 38 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
WriteAttributeValue("", 1042, i.DisplayID, 1042, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1055, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 39 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(1084, 26, true);
            WriteLiteral("            <td>\n\n\t\t</tr>\n");
            EndContext();
#line 43 "/Users/sekiryouma/Documents/coding_dojo/C#/assingments/belt1/Views/Home/dashboard.cshtml"
	}

#line default
#line hidden
            BeginContext(1113, 71, true);
            WriteLiteral("    </tbody>\n</table>\n\n<p><a href=\"/newactivity\">New Activity</a></p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Display>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "922b2ce02a9c0c5dd9d4d0c7e5970f0ae34d8c28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FoodPartials_FoodDetails), @"mvc.1.0.view", @"/Views/Shared/FoodPartials/FoodDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\_ViewImports.cshtml"
using EasyEOrder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\_ViewImports.cshtml"
using EasyEOrder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922b2ce02a9c0c5dd9d4d0c7e5970f0ae34d8c28", @"/Views/Shared/FoodPartials/FoodDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d43671ca04765b153125ddcc2e8728378ed7e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FoodPartials_FoodDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/icons/star-fill.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/icons/star.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" d-flex mt-1 justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""card"">
    <img class=""card-img-top"" src=""https://4cdn.hu/kraken/image/upload/s--mttn3MQz--/w_1160/6pn3V8Q207lICG8Bs.jpeg"" alt=""The Last Supper "" />

    <div class=""card-body"">
        <div class=""card-body-top"">
            <div class=""card-body-left"">
                <h5 class=""card-title"">The Last Supper:  ");
#nullable restore
#line 10 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <h6 class=\"card-subtitle\">\r\n                    Allergének: ");
#nullable restore
#line 13 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                                 foreach (var allergen in Model.FoodAllergens)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                Write(allergen.Allergen);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                                   Write(Html.Raw(", "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </h6>\r\n                <h7 class=\"card-subtitle\">");
#nullable restore
#line 16 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7>\r\n\r\n            </div>\r\n            <div class=\"card-body-rigth\">\r\n");
#nullable restore
#line 20 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                 for (int i = 0; i < Model.Rating; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "922b2ce02a9c0c5dd9d4d0c7e5970f0ae34d8c289113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                 for (int i = 0; i < 5 - Model.Rating; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "922b2ce02a9c0c5dd9d4d0c7e5970f0ae34d8c2810923", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                <div class=\"card-price-text\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-bottom\">\r\n            <p class=\"card-detail-text\">\r\n                ");
#nullable restore
#line 38 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <a id=\"addCart\" class=\"btn buy-button\">Megveszem</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "922b2ce02a9c0c5dd9d4d0c7e5970f0ae34d8c2813595", async() => {
                WriteLiteral("\r\n                <button class=\"btn  buy-button mt-auto\"");
                BeginWriteAttribute("value", " value=\"", 1608, "\"", 1625, 1);
#nullable restore
#line 43 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
WriteAttributeValue("", 1616, Model.Id, 1616, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\">\r\n                    Étel törlése az étlapról\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<script type=""text/javascript"" src=""//ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js""></script>
<script>

    $(document).ready(function () {
        toastr.options = {
            positionClass: 'toast-bottom-center'
        };
        $('#addCart').click(function () {
            $.ajax({
                url: '");
#nullable restore
#line 59 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                 Write(Url.Action("AddCart", "Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \'POST\',\r\n                data: { id: \'");
#nullable restore
#line 61 "C:\Users\krausz.zsolt\Desktop\onlabor\EasyEOrder\EasyEOrder.Web\Views\Shared\FoodPartials\FoodDetails.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
                success: function (data) {

                    toastr.success('Sikeres megrendelés').position;

                },
                error: function () {
                    alert(""error"");
                }
            })
        }
        );
    });
</script>
");
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

#pragma checksum "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa535035d2c2f6cab19f268054dda51c281d6af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HayvanHastaliklari_Olustur), @"mvc.1.0.view", @"/Views/HayvanHastaliklari/Olustur.cshtml")]
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
#line 1 "C:\Users\ezgih\Desktop\Sempati\Views\_ViewImports.cshtml"
using Sempati;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ezgih\Desktop\Sempati\Views\_ViewImports.cshtml"
using Sempati.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa535035d2c2f6cab19f268054dda51c281d6af", @"/Views/HayvanHastaliklari/Olustur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0ae7d024dd7fea9fba704edfbf0b68c49c1bfc", @"/Views/_ViewImports.cshtml")]
    public class Views_HayvanHastaliklari_Olustur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/hayvanhastaliklari/kaydet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("FormAlani"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Üst Başlangıç -->
<div id=""ctl00_cph1_UzunAlan1_panel_alan_4"">


</div>
<!-- Üst Son -->
<section style=""background-color:#FFC061""
    class=""page-header page-header-center  page-header-primary page-header-color page-header-more-padding page-header-no-title-border"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h1 style=""font-size:40px;color:#FFF829"">
                    Hayvan Hastalıkları Kaydet
                </h1>
            </div>
        </div>
    </div>
</section>

<div class=""container"" id=""girisyap"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div id=""ctl00_cph1_PanelOrta"">

                <!-- OrtaAlan2 Başlangıç -->
                <div id=""ctl00_cph1_ctl00_panel_orta"">


                    <!-- ##Blok -->

                    <div class=""Blok"" id=""Uyelik_uyeol"">
                        <div class=""Area"">

                            <div class=""col-md-12"">
               ");
            WriteLiteral(@"                 <div class=""col-md-2""></div>
                                <div class=""col-md-8 "">
                                </div>
                            </div>
                            <div id=""ctl00_cph1_ctl00_ctl00_Panel4"">
                                <div class=""col-md-2""></div>
                                <div class=""col-md-8 "">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa535035d2c2f6cab19f268054dda51c281d6af5729", async() => {
                WriteLiteral("\r\n                                     <input hidden name=\"hastalik_id\"");
                BeginWriteAttribute("value", " value=\"", 1574, "\"", 1600, 1);
#nullable restore
#line 43 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
WriteAttributeValue("", 1582, Model.hastalik_id, 1582, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""col-md-12  margin-bottom"">
                                            <div class=""col-md-12 margin-bottom"">
                                                Hastalik Adı (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""hastalik_adi""");
                BeginWriteAttribute("value", " value=\"", 2055, "\"", 2082, 1);
#nullable restore
#line 49 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
WriteAttributeValue("", 2063, Model.hastalik_adi, 2063, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" maxlength=""70"" class=""form-control"">
                                                </b>
                                            </div>
                                            <div class=""col-md-12 margin-bottom"">
                                                Bulasici (*):
                                                <div class=""clearfix5""></div>
                                                <b>
                                                    <input required name=""bulasici""");
                BeginWriteAttribute("value", " value=\"", 2601, "\"", 2624, 1);
#nullable restore
#line 56 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
WriteAttributeValue("", 2609, Model.bulasici, 2609, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\r\n                                                </b>\r\n                                            </div>\r\n\r\n                                            <div class=\"col-md-12 margin-bottom\">\r\n");
#nullable restore
#line 61 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
                                                 if(Model.hastalik_id!=0){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <a");
                BeginWriteAttribute("href", " href=\"", 2970, "\"", 3022, 2);
                WriteAttributeValue("", 2977, "/hayvanhastaliklari/sil?id=", 2977, 27, true);
#nullable restore
#line 62 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
WriteAttributeValue("", 3004, Model.hastalik_id, 3004, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n");
#nullable restore
#line 63 "C:\Users\ezgih\Desktop\Sempati\Views\HayvanHastaliklari\Olustur.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input type=\"submit\" value=\"Güncelle\" class=\"btn btn-success\">\r\n                                            </div>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                        <!-- Blok Alan -->
                    </div>
                    <!-- Blok Gölge -->
                    <div class=""Golge"">
                        &nbsp;
                    </div>
                    <!-- Blok Gölge -->


                </div>
                <!-- OrtaAlan2 Son -->
            </div>
        </div>

    </div>
</div>

<div id=""ctl00_cph1_orta"">

    <!-- OrtaAlan1 Başlangıç -->
    <div id=""ctl00_cph1_ctl01_panel_orta"">


    </div>
    <!-- OrtaAlan1 Son -->
</div>");
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

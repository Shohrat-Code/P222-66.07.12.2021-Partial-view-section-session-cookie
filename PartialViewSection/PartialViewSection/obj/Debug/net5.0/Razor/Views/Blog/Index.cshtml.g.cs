#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e42a634e27b74beea062551b928ef083a6586cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42a634e27b74beea062551b928ef083a6586cee", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3367806709322771f0ed7b312494991c57be9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\66.07.12.2021-Partial view, section, session, cookie\Codes\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""hero-wrap hero-bread"" style=""background-image:url(images/xbg_1.jpg.pagespeed.ic.-7ny5J_MsG.jpg)"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Blog</span></p>
                <h1 class=""mb-0 bread"">Blog</h1>
            </div>
        </div>
    </div>
</div>
<section class=""ftco-section ftco-degree-bg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 ftco-animate"">
                <div class=""row"">
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_1.jpg');"">
                            </a>
           ");
            WriteLiteral(@"                 <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
                                </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3"">Read more</a></p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=");
            WriteLiteral(@"""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_2.jpg');"">
                            </a>
                            <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
                                </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3""");
            WriteLiteral(@">Read more</a></p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_3.jpg');"">
                            </a>
                            <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
                                </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>F");
            WriteLiteral(@"ar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3"">Read more</a></p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_4.jpg');"">
                            </a>
                            <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
  ");
            WriteLiteral(@"                              </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3"">Read more</a></p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_5.jpg');"">
                            </a>
                            <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""");
            WriteLiteral(@"#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
                                </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3"">Read more</a></p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex ftco-animate"">
                        <div class=""blog-entry align-self-stretch d-md-flex"">
                            <a href=""blog-single.html"" class=""block-20"" style=""background-image: url('images/image_6");
            WriteLiteral(@".jpg');"">
                            </a>
                            <div class=""text d-block pl-md-4"">
                                <div class=""meta mb-3"">
                                    <div><a href=""#"">July 20, 2019</a></div>
                                    <div><a href=""#"">Admin</a></div>
                                    <div><a href=""#"" class=""meta-chat""><span class=""icon-chat""></span> 3</a></div>
                                </div>
                                <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p><a href=""blog-single.html"" class=""btn btn-primary py-2 px-3"">Read more</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            WriteLiteral("            <div class=\"col-lg-4 sidebar ftco-animate\">\r\n                <div class=\"sidebar-box\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e42a634e27b74beea062551b928ef083a6586cee13872", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <span class=""icon ion-ios-search""></span>
                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Categories</h3>
                    <ul class=""categories"">
                        <li><a href=""#"">Vegetables <span>(12)</span></a></li>
                        <li><a href=""#"">Fruits <span>(22)</span></a></li>
                        <li><a href=""#"">Juice <span>(37)</span></a></li>
                        <li><a href=""#"">Dries <span>(42)</span></a></li>
                    </ul>
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Recent Blog</h3>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_1.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                           ");
            WriteLiteral(@" <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_2.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></di");
            WriteLiteral(@"v>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_3.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                </div>
         ");
            WriteLiteral(@"       <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Tag Cloud</h3>
                    <div class=""tagcloud"">
                        <a href=""#"" class=""tag-cloud-link"">fruits</a>
                        <a href=""#"" class=""tag-cloud-link"">tomatoe</a>
                        <a href=""#"" class=""tag-cloud-link"">mango</a>
                        <a href=""#"" class=""tag-cloud-link"">apple</a>
                        <a href=""#"" class=""tag-cloud-link"">carrots</a>
                        <a href=""#"" class=""tag-cloud-link"">orange</a>
                        <a href=""#"" class=""tag-cloud-link"">pepper</a>
                        <a href=""#"" class=""tag-cloud-link"">eggplant</a>
                    </div>
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Paragraph</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia d");
            WriteLiteral("electus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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

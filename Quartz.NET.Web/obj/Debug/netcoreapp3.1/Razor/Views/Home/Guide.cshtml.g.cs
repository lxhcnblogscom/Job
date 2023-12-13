#pragma checksum "E:\os\cloud\Quartz.NetUI\Quartz.NET.Web\Views\Home\Guide.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f807f2bde78222dc6a35d1ba9303c5049cdd0e608bea366e02d0d4a13768b6a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Guide), @"mvc.1.0.view", @"/Views/Home/Guide.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\os\cloud\Quartz.NetUI\Quartz.NET.Web\Views\_ViewImports.cshtml"
using Quartz.NET.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\os\cloud\Quartz.NetUI\Quartz.NET.Web\Views\_ViewImports.cshtml"
using Quartz.NET.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f807f2bde78222dc6a35d1ba9303c5049cdd0e608bea366e02d0d4a13768b6a3", @"/Views/Home/Guide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"625f5e3405b1e2a6fb1fbdd54a344e6dd0a41d5bfc65d4de7e1f3048e7259fca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Guide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\os\cloud\Quartz.NetUI\Quartz.NET.Web\Views\Home\Guide.cshtml"
  
    ViewData["Title"] = "指南";
    Layout = "~/Views/Shared/Vue.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"guide\">\r\n    <div ");
            WriteLiteral(@"@click=""close"" v-show=""show"" class=""big-img-container"">
        <div class=""mask""></div>
        <img v-bind:src=""src"" />
    </div>
    <div class=""g-content"">
        <h1 style=""box-sizing: border-box; margin-right: 0px; margin-bottom: 16px; margin-left: 0px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255); margin-top: 0px !important;"">
            运行环境
        </h1>
        <p style=""box-sizing: border-box; margin-bottom: 16px; margin-top: 0px; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(");
            WriteLiteral(@"255, 255, 255);"">
            .net core版本2.1及以上 vs2017
        </p>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            <a class=""anchor"" href=""https://github.com/cq-panda/Quartz.NetUI/blob/master/README.md#%E5%BC%80%E7%AE%B1%E5%8D%B3%E7%94%A8"" style=""box-sizing: border-box; background-color: transparent; color: rgb(3, 102, 214); text-decoration-line: none; float: left; line-height: 1; margin-left: -20px; padding-right: 4px;""></a>开箱即用
        </h1>
        <p style=""box-sizing: border-box; margin-bottom: 16px; margin-top: 0px; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helve");
            WriteLiteral(@"tica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            直接运行Quartz.NetUI\Quartz.NET.Web目录下run.bat文件或部署项目
            <br />登陆token存放于appsettings.json节点token
            <br />管理员帐号位于节点superToken
        </p>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            <a class=""anchor"" href=""https://github.com/cq-panda/Quartz.NetUI/blob/master/README.md#%E5%9C%A8%E7%BA%BF%E6%BC%94%E7%A4%BA%E5%9C%B0%E5%9D%80"" style=""box-sizing: border-box; background-color: transparent; color: rgb(3, 102, 214); text-decorat");
            WriteLiteral(@"ion-line: none; float: left; line-height: 1; margin-left: -20px; padding-right: 4px;""></a>
        </h1>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            在线演示地址
        </h1>
        <p style=""box-sizing: border-box; margin-bottom: 16px; margin-top: 0px; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            <a href=""http://task.volcore.xyz/"" style=""box-sizing: border-box; background-color: trans");
            WriteLiteral(@"parent; color: rgb(3, 102, 214); text-decoration-line: none;"">http://task.volcore.xyz</a>&nbsp;登陆token为task123456
        </p>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            作业列表
        </h1>
        <img ");
            WriteLiteral(@"@click=""showBigImg('/images/example/tasklist.png')"" src=""/images/example/tasklist.png"" />
        <p>
            <span style=""background-color: rgb(255, 255, 255); color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;;""></span>
        </p>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            新建作业
        </h1>
        <img ");
            WriteLiteral(@"@click=""showBigImg('/images/example/add.png')"" src=""/images/example/add.png"" />
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            修改作业
        </h1>
        <img ");
            WriteLiteral(@"@click=""showBigImg('/images/example/update.png')"" src=""/images/example/update.png"" />
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            查看日志
        </h1>
        <img ");
            WriteLiteral(@"@click=""showBigImg('/images/example/log.png')"" src=""/images/example/log.png"" />
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            配置文件QuartzSettings
        </h1>
        <img src=""/images/example/dir.png"" />
        <p>
            <span style=""color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; background-color: rgb(255, 255, 255);"">配置文件QuartzSettings由系统自动生成,所在位置与当前项目同级,生成文件包括作业参数配置及日志文件初始化</span><span style=""background-color: rgb(255, 255, 255); color: rgb(36, 41");
            WriteLiteral(@", 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;;""></span><br />
        </p>
        <h1 style=""box-sizing: border-box; margin: 24px 0px 16px; line-height: 1.25; border-bottom: 1px solid rgb(234, 236, 239); padding-bottom: 0.3em; color: rgb(36, 41, 46); font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Helvetica, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;; white-space: normal; background-color: rgb(255, 255, 255);"">
            配置文件目录结构
        </h1>
        <img src=""/images/example/project1.png"" />
        <img src=""/images/example/project2.png"" />
        <p>
            ├─Constant
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; QuartzFileInfo.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Contr");
            WriteLiteral(@"ollers
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; HealthController.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; HomeController.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; TaskBackGroundController.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Enum
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; JobAction.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Extensions
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; ConvertPath.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; QuartzNETExtension.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Filters
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; TaskAuthorizeFilter.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
       ");
            WriteLiteral(@" <p>
            ├─Models
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; TaskLog.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; TaskOptions.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Utility
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; FileHelper.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; FileQuartz.cs&nbsp;&nbsp;
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; HttpManager.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; HttpResultful.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; TaskCurrent.cs
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            ├─Views&nbsp;&nbsp;
        </p>
        <p>
            │─TaskBackGround
        </p>
        <p>
            │&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Index.cshtml
        </p>
        <p>
            │&nbsp; &nbsp; &nb");
            WriteLiteral(@"sp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            └─wwwroot
        </p>
        <p>
            &nbsp; &nbsp; │&nbsp; &nbsp; &nbsp; task_index.css&nbsp; &nbsp; &nbsp; &nbsp;
        </p>
        <p>
            &nbsp; &nbsp; │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            &nbsp; &nbsp; ├─iView
        </p>
        <p>
            &nbsp; &nbsp; │&nbsp; &nbsp; &nbsp; iview.min.js
        </p>
        <p>
            &nbsp; &nbsp; │&nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            &nbsp; &nbsp; ├─js
        </p>
        <p>
            &nbsp; &nbsp; │&nbsp; &nbsp; &nbsp; task-index.js&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        </p>
        <p>
            &nbsp; &nbsp; └─vue
        </p>
        <p>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; vue.js
        </p>
        <p>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        </p>
        <p>
            <br />
        </p>
    </div>
</");
            WriteLiteral(@"div>
<style>
    #guide {
        padding: 30px;
        width: 100%;
        position: relative;
        display: inline-block;
        overflow-y: scroll;
        height: calc( 100% - 60px);
    }

        #guide .g-content {
            height: 100%;
            position: absolute;
            max-width: 1000px;
            left: 0;
            right: 0;
            margin: 0 auto;
        }

        #guide img {
            width: 100%;
        }
    .big-img-container {
        left: 0px;
        right: 0px;
        top: 0px;
        z-index: 90;
        position: fixed;
        width: 100%;
    }
        /*.big-img-container img {
            z-index: 999999;
            width: 10%;
            width: 80%;
            position: absolute;
            left: 0;
            right: 0;
            margin: 0 auto;
        }
        .big-img-container .mask {
            opacity: 0.7;
            height: 100%;
            position: fixed;
            display: inline-b");
            WriteLiteral(@"lock;
            width: 100%;
            background: #858484;
            z-index: 0;
        }*/
</style>
<script>
    window.onload = function () {
        $headerVue.activedIndex = 1;
    }
    new Vue({
        el: ""#guide"",
        data: {
            show: false,
            src: '/images/example/tasklist.png',
        },
        methods: {
            showBigImg: function (src) {
                this.src = src;
                this.show = true;
            },
            close: function () {
                this.show = false;
            }
        }, created: function () {
        }, mounted: function () {
        }
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

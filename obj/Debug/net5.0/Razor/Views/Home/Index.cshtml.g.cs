#pragma checksum "C:\Users\ASUS\Desktop\BasicCalculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b1b2c8fb44099a9f901154b7acbf6751134b930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BasicCalculator\Views\_ViewImports.cshtml"
using BasicCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BasicCalculator\Views\_ViewImports.cshtml"
using BasicCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b1b2c8fb44099a9f901154b7acbf6751134b930", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d349eec2d6155d98be71ac81624f0aa4ada8b3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\BasicCalculator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .btn-orange {
        color: white;
        background-color: #EF952D;
    }

    .btn-orange:hover {
        color: white;
        background-color: #e58d29;
    }
</style>

<div class=""card col-sm-5 mx-auto"" style=""background-color: #00000022;"">
    <div class=""card-body"">
        <div class=""row"">
            <h1>Basic Calculator</h1>
        </div>

        <div class=""row"">
            <input id=""calculator"" class=""form-control bg-white text-right"" type=""text"" value=""0"" readonly>
        </div>

        <div class=""row mt-3"">
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('1')"">1</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('2')"">2</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('3')"">3</button>
            <button class=""btn btn-orange col m-1"" onclick=""addNum('1')"">+</button>
        </div>
        <div class=""row"">
            <button class=""btn btn-secondary col m-1"" oncl");
            WriteLiteral(@"ick=""addNum('4')"">4</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('5')"">5</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('6')"">6</button>
            <button class=""btn btn-orange col m-1"" onclick=""addNum('1')"">-</button>
        </div>
        <div class=""row"">
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('7')"">7</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('8')"">8</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('9')"">9</button>
            <button class=""btn btn-orange col m-1"" onclick=""addNum('1')"">*</button>
        </div>
        <div class=""row"">
            <button class=""btn btn-secondary col m-1"" onclick=""addNum('0')"">0</button>
            <button class=""btn btn-secondary col m-1"" onclick=""addDecimal()"">.</button>
            <button class=""btn btn-primary col m-1"" onclick=""addNum('1')"">=</button>
            <button class=""btn btn-");
            WriteLiteral(@"orange col m-1"" onclick=""addNum('1')"">/</button>
        </div>
        <div class=""row mt-3"">
            <button class=""btn btn-danger col"" onclick=""clearCal()"">CLEAR</button>
        </div>

    </div>
</div>

<script>

    var xmlhttp;
    var calculator = document.getElementById(""calculator"");
    var isDecimal = false;

    if (window.ActiveXObject) {
        xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
    } else {
        xmlhttp = new XMLHttpRequest();
    }

    function makerequest(serverPage, objID) {
        var obj = document.getElementById(objID);
        xmlhttp.open(""GET"", serverPage);
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                obj.innerHTML = xml.http.responseText;
            }
        }
        xmlhttp.send();
    }

    function addNum(number) {
        if( calculator.value === ""0"") {
            calculator.value = """";
        }
        console.log(""Add numb");
            WriteLiteral(@"er: "" + number)
        calculator.value = calculator.value + number;
    }

    function addDecimal() {
        if (isDecimal == false) {
            isDecimal = true;
            console.log(""Add decimal !"")
            calculator.value = calculator.value + ""."";
        } else {
            console.log(""Already add decimal, nothing happen"")
        }
    }

    function operation(operand) {
        makerequest()
    }

    function clearCal() {
        console.log(""clear"")
        isDecimal = false;
        calculator.value = ""0"";
        // clear backend
    }
</script>");
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
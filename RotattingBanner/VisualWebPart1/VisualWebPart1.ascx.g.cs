﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RotattingBanner.VisualWebPart1 {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class VisualWebPart1 {
        
        public static implicit operator global::System.Web.UI.TemplateControl(VisualWebPart1 target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::RotattingBanner.VisualWebPart1.VisualWebPart1 @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<link type=\"text/css\" rel=\"stylesheet\" href=\"../_layouts/15/RotattingBanner/fle" +
                        "xslider.css\" />\r\n<script type=\"text/javascript\" src=\"../_layouts/15/RotattingBan" +
                        "ner/jquery.flexslider-min.js\"></script>\r\n<div class=\"flexslider\">\r\n    <ul class" +
                        "=\"slides\">\r\n    </ul>\r\n</div>\r\n<script type=\"text/javascript\">\r\n    $(function (" +
                        ") {\r\n\r\n        var homepageBannerList = [];\r\n        var bannerURL = _spPageCont" +
                        "extInfo.webAbsoluteUrl + \"/_api/web/lists/getbytitle(\'Home Page Banner\')/items?$" +
                        "select=Target_x0020_URL,Title,Embedded_x0020_Text,Embedded_x0020_Text_x0020_Colo" +
                        "r,TitleColor,FileRef,Sort_x0020_Order&$orderby=Sort_x0020_Order&$filter=Enabled " +
                        "eq 1\";\r\n        $.ajax({\r\n            url: bannerURL,\r\n            method: \"GET\"" +
                        ",\r\n            headers: { \"Accept\": \"application/json; odata=verbose\" },\r\n      " +
                        "      async: false,\r\n            success: function (data) {\r\n                $.e" +
                        "ach(data.d.results, function (i, val) {\r\n                    homepageBannerList." +
                        "push({ TargetURL: val[\"Target_x0020_URL\"][\"Url\"], ImageURL: val[\"FileRef\"], Titl" +
                        "e: val[\"Title\"], TitleColor: val[\"TitleColor\"], Description: val[\"Embedded_x0020" +
                        "_Text\"], EmbeddedTextColor: val[\"Embedded_x0020_Text_x0020_Color\"] });\r\n        " +
                        "        });\r\n                var bannerHtml = \"\";\r\n                for (var i = " +
                        "0; i < homepageBannerList.length; i++) {\r\n                    bannerHtml += \"<li" +
                        "><a href=\'\" + homepageBannerList[i].TargetURL + \"\'><img src=\'\" + homepageBannerL" +
                        "ist[i].ImageURL + \"\'/><a/><div class=\'slide-caption\'><h1 style=\'color:\" + homepa" +
                        "geBannerList[i].TitleColor + \"\'>\" + homepageBannerList[i].Title + \"</h1><div sty" +
                        "le=\'color:\" + homepageBannerList[i].EmbeddedTextColor + \"\'>\" + homepageBannerLis" +
                        "t[i].Description + \"</div></div></div></li>\";\r\n                }\r\n              " +
                        "  $(\".flexslider ul\").html(bannerHtml);\r\n            },\r\n            error: func" +
                        "tion (data) {\r\n                alert(\"\");\r\n            }\r\n        });\r\n\r\n       " +
                        " $(\'.flexslider\').flexslider({\r\n            animation: \"slide\",\r\n            sli" +
                        "deshow: true,               //Slideshow: true or false\r\n            slideshowSpe" +
                        "ed: 5500,           //Slideshow speed: numeric\r\n            animationDuration: 3" +
                        "000,         //Duration: numeric\r\n            directionNav: false,             /" +
                        "/Next/Prev: true or false\r\n            animationLoop: true,\r\n            pauseOn" +
                        "Hover: true,\r\n            controlNav: true,\r\n            slideshow: true,\r\n     " +
                        "       smoothHeight: true\r\n        });\r\n    });\r\n</script>\r\n"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
﻿using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Util.Ui.Services {
    /// <summary>
    /// 组件服务
    /// </summary>
    public class UiServiceBase<TModel> : IContext<TModel> {
        /// <summary>
        /// 初始化组件服务
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <param name="encoder">Html编码</param>
        public UiServiceBase( IHtmlHelper<TModel> helper, HtmlEncoder encoder ) {
            Helper = helper;
            Encoder = encoder;
        }

        /// <summary>
        /// HtmlHelper
        /// </summary>
        public IHtmlHelper<TModel> Helper { get; }

        /// <summary>
        /// Html编码
        /// </summary>
        public HtmlEncoder Encoder { get; }
    }
}
﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taylor
{
    /// <summary>
    /// 系统扩展 - 基础设施
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 注册Util基础设施服务
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="configs">依赖配置</param>
        //public static IServiceProvider AddTaylor(this IServiceCollection services, params IConfig[] configs)
        //{
        //    return new DependencyConfiguration(services, configs).Config();
        //}
    }
}

﻿using System.Text;
using Util.Logs.Abstractions;
using Util.Logs.Core;

namespace Util.Logs.Extensions {
    /// <summary>
    /// 日志扩展
    /// </summary>
    public static class Extensions {
        /// <summary>
        /// 设置业务编号
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="businessId">业务编号</param>
        public static ILog BusinessId( this ILog log, string businessId ) {
            return log.Set<LogContent>( content => content.BusinessId = businessId );
        }

        /// <summary>
        /// 设置模块
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="module">模块</param>
        public static ILog Module( this ILog log, string module ) {
            return log.Set<LogContent>( content => content.Module = module );
        }

        /// <summary>
        /// 设置类名
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="class">类名</param>
        public static ILog Class( this ILog log, string @class ) {
            return log.Set<LogContent>( content => content.Class = @class );
        }

        /// <summary>
        /// 设置方法
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="method">方法</param>
        public static ILog Method( this ILog log, string method ) {
            return log.Set<LogContent>( content => content.Method = method );
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="value">值</param>
        /// <param name="args">变量值</param>
        public static ILog Params( this ILog log, string value, params object[] args ) {
            return log.Set<LogContent>( content => content.Append( content.Params,value,args ) );
        }

        /// <summary>
        /// 设置参数并换行
        /// </summary>
        /// <param name="log">日志操作</param>
        /// <param name="value">值</param>
        /// <param name="args">变量值</param>
        public static ILog ParamsLine( this ILog log, string value, params object[] args ) {
            return log.Set<LogContent>( content => content.AppendLine( content.Params, value, args ) );
        }
    }
}
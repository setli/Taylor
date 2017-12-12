using System;

namespace Taylor
{
    /// <summary>
    /// 系统扩展 类型转换
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// 去前后空格,为null返回""
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string SafeString(this object input)
        {
            return input == null ? string.Empty : input.ToString().Trim();
        }
    }
}

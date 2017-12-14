
namespace Taylor.Helpers
{
    /// <summary>
    /// string扩展方法
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// 判断该字符串是null或空字符串
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str) || str.Trim().Length == 0;
        }

        /// <summary>
        /// 判断该字符串不是null或空字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !str.IsNullOrEmpty();
        }

        /// <summary>
        /// 表示这个字符串是null，是空，还是只由空格字符组成
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}

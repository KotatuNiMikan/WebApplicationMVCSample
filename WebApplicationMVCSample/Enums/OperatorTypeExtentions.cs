using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplicationMVCSample.Enums
{
    /// <summary>
    /// <see cref="OperatorType"/>の拡張メソッドクラスです。
    /// </summary>
    public static class OperatorTypeExtentions
    {
        /// <summary>
        /// 表示名を取得します。
        /// </summary>
        /// <param name="self">四則演算の種類です。</param>
        /// <returns>表示名です。</returns>
        public static string GetDisplayName(this OperatorType self)
        {
            var fieldInfo = self.GetType().GetField(self.ToString());
            var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false)
                .First() as DisplayAttribute;
            return descriptionAttribute.GetName();
        }

        /// <summary>
        /// 計算を実施します。
        /// </summary>
        /// <param name="self">四則演算の種類です。</param>
        /// <param name="left">左辺です。</param>
        /// <param name="right">右辺です。</param>
        /// <returns>計算結果です。</returns>
        public static long Calculate(this OperatorType self, long left, long right)
        {
            if (self == OperatorType.Addition)
            {
                return left + right;
            }

            if (self == OperatorType.Minus)
            {
                return left - right;
            }

            if (self == OperatorType.Multiply)
            {
                return left * right;
            }

            return left / right;
        }
    }
}
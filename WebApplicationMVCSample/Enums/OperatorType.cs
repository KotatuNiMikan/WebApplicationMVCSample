using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCSample.Enums
{
    /// <summary>
    /// 四則演算の種類です。
    /// </summary>
    public enum OperatorType
    {
        /// <summary>
        /// 加算です。
        /// </summary>
        [Display(Name = "+")]
        Addition,

        /// <summary>
        /// 減算です。
        /// </summary>
        [Display(Name = "-")]
        Minus,

        /// <summary>
        /// 乗算です。
        /// </summary>
        [Display(Name = "×")]
        Multiply,

        /// <summary>
        /// 除算です。
        /// </summary>
        [Display(Name = "/")]
        Division
    }
}
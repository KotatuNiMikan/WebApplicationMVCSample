using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using WebApplicationMVCSample.Enums;

namespace WebApplicationMVCSample.Models.Calculation
{
    /// <summary>
    /// 四則演算画面のビューモデルです。
    /// </summary>
    public class IndexModel : IValidatableObject
    {
        /// <summary>
        /// 左辺です。
        /// </summary>
        [DisplayName("左辺")]
        [Required]
        public long? Left { get; set; }

        /// <summary>
        /// 右辺です。
        /// </summary>
        [DisplayName("右辺")]
        [Required]
        public long? Right { get; set; }

        /// <summary>
        /// 演算子です。
        /// </summary>
        [DisplayName("演算子")]
        public OperatorType OperatorType { get; set; }

        /// <summary>
        /// 演算子の選択項目です。
        /// </summary>
        public IEnumerable<SelectListItem> OperatorTypeList => Enum.GetValues(typeof(OperatorType))
            .OfType<OperatorType>()
            .Select(item => new SelectListItem
            {
                Text = item.GetDisplayName(),
                Value = item.ToString()
            });

        /// <summary>
        /// 結果を取得します。
        /// </summary>
        /// <returns>四則演算結果画面に表示する文字列です。</returns>
        public string GetResult()
        {
            return $"{Left} {OperatorType.GetDisplayName()} {Right} = {OperatorType.Calculate(Left.Value, Right.Value)}";
        }
        
        /// <summary>
        /// 検証を行います。
        /// </summary>
        /// <param name="validationContext">検証チェックの実行コンテキストです。</param>
        /// <returns>検証結果の列挙です。</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
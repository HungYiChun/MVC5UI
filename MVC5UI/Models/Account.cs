namespace MVC5UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "此欄位僅接受4~16個字")]
        [Display(Name = "帳號")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "請輸入密碼格式")]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "請輸入E-mail格式")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "此欄位僅接受50個字以內")]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "請輸入E-mail格式")]
        [Display(Name = "電話")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "請輸入E-mail格式")]
        [Display(Name = "手機")]
        public string Cellphone { get; set; }

        [Display(Name = "權限")]
        public int RoleId { get; set; }

        [Display(Name = "狀態")]
        public int StatusId { get; set; }

        // 表單欄位驗證
        // [Display(Name = "帳號")]: 設定欄位"顯示"

        // [Required]: 設定欄位為必填      
        // [Required(ErrorMessage = "錯誤訊息")]: 設定欄位為必填，當輸入錯誤時，顯示設定的錯誤訊息

        // [StringLength(50, ErrorMessage = "此欄位僅接受50個字以內")]: 設定欄位字串最大長度
        // [StringLength(16, MinimumLength = 4, ErrorMessage = "此欄位僅接受4~16個字")]: 設定欄位字串長度區間

        // [Range(10, 1000, ErrorMessage = "超出數字範圍")]: 設定數字的大小範圍

        // [DataType(DataType.EmailAddress, ErrorMessage = "請輸入E-mail格式")]: 設定欄位為E-mail格式驗證，
        // DataType.Password為密碼格式驗證，DataType.PhoneNumber為電話格式驗證，DataType.DateTime為時間格式驗證......等

        // [Remote("AccountAgain", "Home", HttpMethod = "POST", ErrorMessage = "ActionResult驗證")]:
        // 透過遠端Action POST 或 GET驗證欄位，例如:帳號重覆申請。

        // [RegularExpression(@"[a-zA-Z]+[a-zA-Z0-9]*$", ErrorMessage = "密碼僅能有英文或數字，且開頭需為英文字母！")]: 自訂欄位驗證
        // 符號意義請參考"正規表示式" https://developer.mozilla.org/zh-TW/docs/Web/JavaScript/Guide/Regular_Expressions

        // [System.Web.Mvc.Compare("Password", ErrorMessage = "您的密碼並不相同，請輸入相同的密碼 !")]: 欄位需與特定欄位相等
    }
}

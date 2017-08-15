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
        [StringLength(16, MinimumLength = 4, ErrorMessage = "�����ȱ���4~16�Ӧr")]
        [Display(Name = "�b��")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "�п�J�K�X�榡")]
        [Display(Name = "�K�X")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "�п�JE-mail�榡")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "�����ȱ���50�Ӧr�H��")]
        [Display(Name = "�m�W")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "�п�JE-mail�榡")]
        [Display(Name = "�q��")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "�п�JE-mail�榡")]
        [Display(Name = "���")]
        public string Cellphone { get; set; }

        [Display(Name = "�v��")]
        public int RoleId { get; set; }

        [Display(Name = "���A")]
        public int StatusId { get; set; }

        // ����������
        // [Display(Name = "�b��")]: �]�w���"���"

        // [Required]: �]�w��쬰����      
        // [Required(ErrorMessage = "���~�T��")]: �]�w��쬰����A���J���~�ɡA��ܳ]�w�����~�T��

        // [StringLength(50, ErrorMessage = "�����ȱ���50�Ӧr�H��")]: �]�w���r��̤j����
        // [StringLength(16, MinimumLength = 4, ErrorMessage = "�����ȱ���4~16�Ӧr")]: �]�w���r����װ϶�

        // [Range(10, 1000, ErrorMessage = "�W�X�Ʀr�d��")]: �]�w�Ʀr���j�p�d��

        // [DataType(DataType.EmailAddress, ErrorMessage = "�п�JE-mail�榡")]: �]�w��쬰E-mail�榡���ҡA
        // DataType.Password���K�X�榡���ҡADataType.PhoneNumber���q�ܮ榡���ҡADataType.DateTime���ɶ��榡����......��

        // [Remote("AccountAgain", "Home", HttpMethod = "POST", ErrorMessage = "ActionResult����")]:
        // �z�L����Action POST �� GET�������A�Ҧp:�b�����ХӽСC

        // [RegularExpression(@"[a-zA-Z]+[a-zA-Z0-9]*$", ErrorMessage = "�K�X�ȯ঳�^��μƦr�A�B�}�Y�ݬ��^��r���I")]: �ۭq�������
        // �Ÿ��N�q�аѦ�"���W��ܦ�" https://developer.mozilla.org/zh-TW/docs/Web/JavaScript/Guide/Regular_Expressions

        // [System.Web.Mvc.Compare("Password", ErrorMessage = "�z���K�X�ä��ۦP�A�п�J�ۦP���K�X !")]: ���ݻP�S�w���۵�
    }
}

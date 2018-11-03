//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Win_Spa_EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Purchase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя клиента")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Не указано номер клиента")]
        [RegularExpression(@"^\+[380]\d+$", ErrorMessage = "Номер телефона должен иметь формат +380xxxxxxxx")]
        public string PhoneNum { get; set; }
        public System.DateTime Date { get; set; }
        public int IdService { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models.Enums
{
    public enum Status
    {
        [Display(Name ="Неактивен")]
        Inactive,
        [Display(Name = "Активен")]
        Active,
        AnotherStatus
    }
}

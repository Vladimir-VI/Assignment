using System.Globalization;
using System.Windows.Controls;

public class StringLengthValidationRule : ValidationRule
{

    public int Length { get; set; }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (value != null && value.ToString().Length <= this.Length )
        {
            return new ValidationResult(true, null);
        }
        return new ValidationResult(false, $"Броят символи трябва да е по- малък от {this. Length}");
    }
}
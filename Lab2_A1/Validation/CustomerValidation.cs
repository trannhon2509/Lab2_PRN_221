using System.ComponentModel.DataAnnotations;

namespace Lab2_A1.Validation
{
    public class CustomerValidation : ValidationAttribute
    {
        public CustomerValidation()
        {
            ErrorMessage = "The year of birth canot greater than current year 2024";
        }

        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            if (int.TryParse(value.ToString(), out int number))
            {
                return number < 2024;
            }
            return false;
        }
    }
}

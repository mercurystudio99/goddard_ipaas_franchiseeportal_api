using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.Validation
{
    /// <summary>
    /// Conditionally required attribute
    /// </summary>
    /// <see cref="https://www.c-sharpcorner.com/article/dotvvm-build-conditional-validation-attribute/"/>
    public class RequiredIfAttribute : ValidationAttribute
    {
        public string PropertyName { get; set; }
        public object Value { get; set; }

        public RequiredIfAttribute(string propertyName, object value, string errorMessage = "")
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;
            Value = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var instance = validationContext.ObjectInstance;
            var type = instance.GetType();
            var proprtyvalue = type.GetProperty(PropertyName).GetValue(instance, null);
            if (proprtyvalue.Equals(Value) && (value == null || string.IsNullOrWhiteSpace(value?.ToString())))
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}

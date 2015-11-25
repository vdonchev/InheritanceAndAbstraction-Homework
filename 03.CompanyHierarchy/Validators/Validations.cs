namespace _03.CompanyHierarchy.Validators
{
    using System;
    using Models;

    public static class Validations
    {
        public static void IfIsNegative(dynamic value, string type)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), string.Format(CompanyConstants.NumCantBeNegative, type));
            }
        }

        public static void IfIsNull(string value, string type)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), string.Format(CompanyConstants.CantBeNull, type));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLich.ViewModels
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class InventoryMin : ValidationAttribute
    {
        // Fields
        private readonly int _minimum;
        // Constructors
        public InventoryMin(int minValue) : base("Giá trị nhỏ nhất cho phép nhập là 1.")
        {
            _minimum = minValue;
        }
        /*public override bool IsValid(object value)
        {
            var stringValue = value.ToString(); // Ép kiểu giá trị trong form được nhận như kiểu string
            int numericValue = int.Parse(stringValue);

            if(numericValue <= _minimum) // Convert and Compare
            {
                return false; // False sau khi kiểm tra mà giá trị trong form bé hơn định mức tối thiểu cho phép.
            }
            else
            {
                return true;
            }
        }*/
        /*
        public override bool IsValid(object value)
        {
            var stringValue = value as string;
            int numericValue;
            var isValid = int.TryParse(stringValue, out numericValue);
            return (isValid && int.Parse(stringValue) <= _minimum);
        }
        */
        public override bool IsValid(object value)
        {
            var stringValue = value as string;// Ép kiểu string
            int numericValue;
            if (stringValue == null)
                return false;
            else if(!int.TryParse(stringValue, out numericValue) || numericValue < _minimum) // Check < _minimum
            {
                return false;
            }
            return true;
        }
    }
}
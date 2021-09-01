using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    //This model is used to calculate each tax bracket 
    public class TipCalculatorModel
    {
        [Required(ErrorMessage =
        "Please enter a Subtotal.")]
        [Range(1, double.PositiveInfinity, ErrorMessage =
        "Subtotal amount must be more than 0.")]
        public double? Subtotal { get; set; }

        public double? CalculateT1()
        {
            double? T1 = Subtotal * 0.15;
            return T1;
        }
        public double? CalculateT2()
        {

            double? T2 = Subtotal * 0.2;
            return T2;
        }
        public double? CalculateT3()
        {

            double? T3 = Subtotal * 0.25;
            return T3;
        }


    }
}
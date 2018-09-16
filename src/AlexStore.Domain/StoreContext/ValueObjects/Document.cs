using AlexStore.Domain.StoreContext.Extensions;
using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexStore.Domain.StoreContext.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(int number)
        {
            Number = number;
            var contracts = new ValidationContract()
                .Requires()
                .IsTrue(Validate(), "Document", "SIN Invalid");
            AddNotifications(contracts);
        }

        //EF
        protected Document()
        {
        }

        public int Number { get; private set; }

        public override string ToString()
        {
            return Number.ToString();
        }

        //Custom Validation 
        //https://stackoverflow.com/questions/4263398/how-do-i-check-the-validity-of-the-canadian-social-insurance-number-in-c
        private bool Validate()
        {

            var digits = Number.ToDigitEnumerable();

            if (digits.Count() != 9) return false;

            //The left side of the addition is adding all even indexes (except the last digit).
            //We are adding even indexes since .NET uses base 0 for indexes

            //The right side of the addition, multiplies the odd index's value by 2, then breaks each result into
            //individual digits, then adds them together
            var total = digits.Where((value, index) => index % 2 == 0 && index != 8).Sum()
                        + digits.Where((value, index) => index % 2 != 0).Select(v => v * 2)
                              .SelectMany(v => v.ToDigitEnumerable()).Sum();

            //The final modulous 10 operator is to handle the scenarios where the total
            //is divisble by 10, in those cases, the check sum should be 0, not 10
            var checkDigit = (10 - (total % 10)) % 10;

            return digits.Last() == checkDigit;
        }        
    }
}

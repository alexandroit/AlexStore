using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlexStore.Domain.SharedContext.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;
            var contracts = new ValidationContract()
                .Requires()
                .IsEmail(Address, "Address", "Email precisa ser valido");
            AddNotifications(contracts);
        }

        protected Email()
        {

        }

        public string  Address { get; private set; }

        public override string ToString()
        {
            return Address;
        }
    }
}

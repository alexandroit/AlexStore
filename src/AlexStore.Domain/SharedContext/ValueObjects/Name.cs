﻿using FluentValidator;
using FluentValidator.Validation;

namespace AlexStore.Domain.SharedContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            var contracts = new ValidationContract()
                .Requires()
                .HasMinLen(FirstName, 3, "FirstName", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "FirstName", "O nome deve conter no maximo 40 caracteres")
                .HasMinLen(LastName, 3, "LastName", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(LastName, 40, "LastName", "O nome deve conter no maximo 40 caracteres");
            AddNotifications(contracts);
        }

        //EF
        protected Name()
        {

        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

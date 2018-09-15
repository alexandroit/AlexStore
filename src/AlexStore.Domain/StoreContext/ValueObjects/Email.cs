using System;
using System.Collections.Generic;
using System.Text;

namespace AlexStore.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
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

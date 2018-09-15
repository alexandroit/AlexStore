using System;
using System.Collections.Generic;
using System.Text;

namespace AlexStore.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }

        protected Document()
        {
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}

using FluentValidator;
using FluentValidator.Validation;
using SINValidator;

namespace AlexStore.Domain.SharedContext.ValueObjects
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
        
        private bool Validate()
        {
            return new SIN(Number).Validate();  
        }        
    }
}

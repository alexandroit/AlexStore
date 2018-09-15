using System;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(
            string firstName, 
            string lastName, 
            string document, 
            string email, 
            string phone, 
            string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            Phone = phone;
            Address = address;
        }

        #region Properties
        public Guid Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Document { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public string Address { get; private set; }
        #endregion

        #region Methods
        public void Register()
        {

        }
        #endregion

        #region Events
        public void OnRegister()
        {

        }
        #endregion

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}

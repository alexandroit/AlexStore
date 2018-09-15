using AlexStore.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(
            Name name,
            Document document, 
            Email email, 
            string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        #region Properties
        public Guid Id { get; private set; }

        public Name Name { get; private set; }

        public Document Document { get; private set; }

        public Email Email { get; private set; }

        public string Phone { get; private set; }

        public IReadOnlyCollection<Address> Addresses { get; private set; }
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
            return Name.ToString();
        }
    }

}

using System;

namespace AlexStore.Domain.StoreContext.Entities
{
    public class Customer
    {
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
    }

}

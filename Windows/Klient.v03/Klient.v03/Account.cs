//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klient.v03
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Customer = new HashSet<Customer>();
        }
    
        public int Id { get; set; }
        public int Uprawnienia { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string Haslo { get; set; }
    
        public virtual ICollection<Customer> Customer { get; set; }
    }
}

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
    
    public partial class Delivery
    {
        public Delivery()
        {
            this.DeliveryDetail = new HashSet<DeliveryDetail>();
        }
    
        public int Id { get; set; }
        public int DostawcaId { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Provider Provider { get; set; }
        public virtual ICollection<DeliveryDetail> DeliveryDetail { get; set; }
    }
}

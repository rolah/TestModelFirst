//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchases
    {
        public int Id { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomersId { get; set; }
    
        public virtual Customers Customers { get; set; }
    }
}

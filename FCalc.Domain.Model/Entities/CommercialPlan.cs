//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FCalc.Domain.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommercialPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommercialPlan()
        {
            this.CommercialPlanRange = new HashSet<CommercialPlanRange>();
            this.Customer = new HashSet<Customer>();
        }
    
        public int idCommercialplan { get; set; }
        public string name { get; set; }
        public Nullable<int> idPlantype { get; set; }
        public Nullable<decimal> price { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
    
        public virtual PlanType PlanType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommercialPlanRange> CommercialPlanRange { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }
    }
}

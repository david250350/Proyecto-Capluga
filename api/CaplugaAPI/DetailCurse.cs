//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaplugaAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailCurse
    {
        public long DetailCurseID { get; set; }
        public long MedicalCourseID { get; set; }
        public decimal PaidPrice { get; set; }
        public int PaidQuantity { get; set; }
        public decimal Tax { get; set; }
        public long MasterPurchaseCurseID { get; set; }
        public string PaymentStatus { get; set; }
    
        public virtual MasterPurchaseCurse MasterPurchaseCurse { get; set; }
        public virtual MedicalCourses MedicalCourses { get; set; }
    }
}
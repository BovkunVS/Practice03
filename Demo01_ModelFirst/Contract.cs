//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo01_ModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            this.id_contract = 10000;
        }
    
        public int id_contract { get; set; }
        public string id_company_recipient { get; set; }
        public string id_company_supplier { get; set; }
        public string id_product { get; set; }
        public System.DateTime date_of_conclusion { get; set; }
        public int deadline { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Company Company1 { get; set; }
        public virtual Products Products { get; set; }
    }
}
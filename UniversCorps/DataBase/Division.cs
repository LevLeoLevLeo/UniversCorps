//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversCorps.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Division()
        {
            this.UniClassFundCorps = new HashSet<UniClassFundCorps>();
        }
    
        public int Id { get; set; }
        public int IdDepartment { get; set; }
        public Nullable<int> IdFaculty { get; set; }
        public Nullable<int> IdLaboratory { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Laboratory Laboratory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UniClassFundCorps> UniClassFundCorps { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.MyApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class STORMFILTERSETTING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STORMFILTERSETTING()
        {
            this.STORMFILTERDETAIL = new HashSet<STORMFILTERDETAIL>();
            this.STORMFILTERLOOKUP = new HashSet<STORMFILTERLOOKUP>();
            this.STORMWEBSEARCH = new HashSet<STORMWEBSEARCH>();
        }
    
        public System.Guid primaryKey { get; set; }
        public string Name { get; set; }
        public string DataObjectView { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STORMFILTERDETAIL> STORMFILTERDETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STORMFILTERLOOKUP> STORMFILTERLOOKUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STORMWEBSEARCH> STORMWEBSEARCH { get; set; }
    }
}
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
    
    public partial class Компания
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Компания()
        {
            this.Практика = new HashSet<Практика>();
            this.ПредставительКомпании = new HashSet<ПредставительКомпании>();
        }
    
        public System.Guid primaryKey { get; set; }
        public string Название { get; set; }
        public string Информация { get; set; }
        public string Ссылка { get; set; }
        public string ПрактикиИнфо { get; set; }
        public Nullable<bool> Практики { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Практика> Практика { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПредставительКомпании> ПредставительКомпании { get; set; }
    }
}

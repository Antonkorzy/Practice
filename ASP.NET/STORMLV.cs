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
    
    public partial class STORMLV
    {
        public System.Guid primaryKey { get; set; }
        public System.Guid Class_m0 { get; set; }
        public System.Guid View_m0 { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public string Editor { get; set; }
    
        public virtual STORMS STORMS { get; set; }
        public virtual STORMS STORMS1 { get; set; }
    }
}

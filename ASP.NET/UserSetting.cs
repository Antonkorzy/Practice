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
    
    public partial class UserSetting
    {
        public System.Guid primaryKey { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public Nullable<System.Guid> UserGuid { get; set; }
        public string ModuleName { get; set; }
        public Nullable<System.Guid> ModuleGuid { get; set; }
        public string SettName { get; set; }
        public Nullable<System.Guid> SettGuid { get; set; }
        public Nullable<System.DateTime> SettLastAccessTime { get; set; }
        public string StrVal { get; set; }
        public string TxtVal { get; set; }
        public Nullable<int> IntVal { get; set; }
        public Nullable<bool> BoolVal { get; set; }
        public Nullable<System.Guid> GuidVal { get; set; }
        public Nullable<decimal> DecimalVal { get; set; }
        public Nullable<System.DateTime> DateTimeVal { get; set; }
    }
}

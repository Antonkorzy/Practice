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
    
    public partial class Студент
    {
        public System.Guid primaryKey { get; set; }
        public string ФИО { get; set; }
        public string НеобходимостьПрактики { get; set; }
        public string Подготовка { get; set; }
        public Nullable<System.Guid> Практика { get; set; }
        public Nullable<System.Guid> ЗаявкаНаПрактику { get; set; }
        public System.Guid Курс { get; set; }
    
        public virtual ЗаявкаНаПрактику ЗаявкаНаПрактику1 { get; set; }
        public virtual Курс Курс1 { get; set; }
        public virtual Практика Практика1 { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_47130
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Студент.
    /// </summary>
    // *** Start programmer edit section *** (Студент CustomAttributes)

    // *** End programmer edit section *** (Студент CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СтудентE", new string[] {
            "ФИО as \'ФИО\'",
            "НеобходимостьПрактики as \'Необходимость практики\'",
            "Подготовка as \'Подготовка\'",
            "Курс as \'Курс\'",
            "Курс.Названиее as \'Названиее\'",
            "ЗаявкаНаПрактику as \'Заявка на практику\'",
            "ЗаявкаНаПрактику.Информация as \'Информация\'",
            "Практика as \'Практика\'",
            "Практика.Информация as \'Информация\'"})]
    [View("СтудентL", new string[] {
            "ФИО as \'ФИО\'",
            "НеобходимостьПрактики as \'Необходимость практики\'",
            "Подготовка as \'Подготовка\'",
            "Курс.Названиее as \'Названиее\'",
            "ЗаявкаНаПрактику.Информация as \'Информация\'",
            "Практика.Информация as \'Информация\'"})]
    public class Студент : ICSSoft.STORMNET.DataObject
    {
        
        private string fФИО;
        
        private string fНеобходимостьПрактики;
        
        private string fПодготовка;
        
        private IIS.Product_47130.Курс fКурс;
        
        private IIS.Product_47130.ЗаявкаНаПрактику fЗаявкаНаПрактику;
        
        private IIS.Product_47130.Практика fПрактика;
        
        // *** Start programmer edit section *** (Студент CustomMembers)

        // *** End programmer edit section *** (Студент CustomMembers)

        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Студент.ФИО CustomAttributes)

        // *** End programmer edit section *** (Студент.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Студент.ФИО Get start)

                // *** End programmer edit section *** (Студент.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Студент.ФИО Get end)

                // *** End programmer edit section *** (Студент.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.ФИО Set start)

                // *** End programmer edit section *** (Студент.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Студент.ФИО Set end)

                // *** End programmer edit section *** (Студент.ФИО Set end)
            }
        }
        
        /// <summary>
        /// НеобходимостьПрактики.
        /// </summary>
        // *** Start programmer edit section *** (Студент.НеобходимостьПрактики CustomAttributes)

        // *** End programmer edit section *** (Студент.НеобходимостьПрактики CustomAttributes)
        [StrLen(255)]
        public virtual string НеобходимостьПрактики
        {
            get
            {
                // *** Start programmer edit section *** (Студент.НеобходимостьПрактики Get start)

                // *** End programmer edit section *** (Студент.НеобходимостьПрактики Get start)
                string result = this.fНеобходимостьПрактики;
                // *** Start programmer edit section *** (Студент.НеобходимостьПрактики Get end)

                // *** End programmer edit section *** (Студент.НеобходимостьПрактики Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.НеобходимостьПрактики Set start)

                // *** End programmer edit section *** (Студент.НеобходимостьПрактики Set start)
                this.fНеобходимостьПрактики = value;
                // *** Start programmer edit section *** (Студент.НеобходимостьПрактики Set end)

                // *** End programmer edit section *** (Студент.НеобходимостьПрактики Set end)
            }
        }
        
        /// <summary>
        /// Подготовка.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Подготовка CustomAttributes)

        // *** End programmer edit section *** (Студент.Подготовка CustomAttributes)
        [StrLen(255)]
        public virtual string Подготовка
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Подготовка Get start)

                // *** End programmer edit section *** (Студент.Подготовка Get start)
                string result = this.fПодготовка;
                // *** Start programmer edit section *** (Студент.Подготовка Get end)

                // *** End programmer edit section *** (Студент.Подготовка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Подготовка Set start)

                // *** End programmer edit section *** (Студент.Подготовка Set start)
                this.fПодготовка = value;
                // *** Start programmer edit section *** (Студент.Подготовка Set end)

                // *** End programmer edit section *** (Студент.Подготовка Set end)
            }
        }
        
        /// <summary>
        /// Студент.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Курс CustomAttributes)

        // *** End programmer edit section *** (Студент.Курс CustomAttributes)
        [NotNull()]
        public virtual IIS.Product_47130.Курс Курс
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Курс Get start)

                // *** End programmer edit section *** (Студент.Курс Get start)
                IIS.Product_47130.Курс result = this.fКурс;
                // *** Start programmer edit section *** (Студент.Курс Get end)

                // *** End programmer edit section *** (Студент.Курс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Курс Set start)

                // *** End programmer edit section *** (Студент.Курс Set start)
                this.fКурс = value;
                // *** Start programmer edit section *** (Студент.Курс Set end)

                // *** End programmer edit section *** (Студент.Курс Set end)
            }
        }
        
        /// <summary>
        /// Студент.
        /// </summary>
        // *** Start programmer edit section *** (Студент.ЗаявкаНаПрактику CustomAttributes)

        // *** End programmer edit section *** (Студент.ЗаявкаНаПрактику CustomAttributes)
        public virtual IIS.Product_47130.ЗаявкаНаПрактику ЗаявкаНаПрактику
        {
            get
            {
                // *** Start programmer edit section *** (Студент.ЗаявкаНаПрактику Get start)

                // *** End programmer edit section *** (Студент.ЗаявкаНаПрактику Get start)
                IIS.Product_47130.ЗаявкаНаПрактику result = this.fЗаявкаНаПрактику;
                // *** Start programmer edit section *** (Студент.ЗаявкаНаПрактику Get end)

                // *** End programmer edit section *** (Студент.ЗаявкаНаПрактику Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.ЗаявкаНаПрактику Set start)

                // *** End programmer edit section *** (Студент.ЗаявкаНаПрактику Set start)
                this.fЗаявкаНаПрактику = value;
                // *** Start programmer edit section *** (Студент.ЗаявкаНаПрактику Set end)

                // *** End programmer edit section *** (Студент.ЗаявкаНаПрактику Set end)
            }
        }
        
        /// <summary>
        /// Студент.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Практика CustomAttributes)

        // *** End programmer edit section *** (Студент.Практика CustomAttributes)
        public virtual IIS.Product_47130.Практика Практика
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Практика Get start)

                // *** End programmer edit section *** (Студент.Практика Get start)
                IIS.Product_47130.Практика result = this.fПрактика;
                // *** Start programmer edit section *** (Студент.Практика Get end)

                // *** End programmer edit section *** (Студент.Практика Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Практика Set start)

                // *** End programmer edit section *** (Студент.Практика Set start)
                this.fПрактика = value;
                // *** Start programmer edit section *** (Студент.Практика Set end)

                // *** End programmer edit section *** (Студент.Практика Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СтудентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтудентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтудентE", typeof(IIS.Product_47130.Студент));
                }
            }
            
            /// <summary>
            /// "СтудентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтудентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтудентL", typeof(IIS.Product_47130.Студент));
                }
            }
        }
    }
}

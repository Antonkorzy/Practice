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
    /// Заявка на практику.
    /// </summary>
    // *** Start programmer edit section *** (ЗаявкаНаПрактику CustomAttributes)

    // *** End programmer edit section *** (ЗаявкаНаПрактику CustomAttributes)
    [AutoAltered()]
    [Caption("Заявка на практику")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаявкаНаПрактикуE", new string[] {
            "Информация as \'Информация\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "ПредставительОУ as \'Представитель ОУ\'",
            "ПредставительОУ.Имя as \'Имя\'"})]
    [View("ЗаявкаНаПрактикуL", new string[] {
            "Информация as \'Информация\'",
            "ДатаНачала as \'Дата начала\'",
            "ДатаКонца as \'Дата конца\'",
            "ПредставительОУ.Имя as \'Имя\'"})]
    public class ЗаявкаНаПрактику : ICSSoft.STORMNET.DataObject
    {
        
        private string fИнформация;
        
        private System.DateTime fДатаНачала;
        
        private System.DateTime fДатаКонца;
        
        private IIS.Product_47130.ПредставительОУ fПредставительОУ;
        
        // *** Start programmer edit section *** (ЗаявкаНаПрактику CustomMembers)

        // *** End programmer edit section *** (ЗаявкаНаПрактику CustomMembers)

        
        /// <summary>
        /// Информация.
        /// </summary>
        // *** Start programmer edit section *** (ЗаявкаНаПрактику.Информация CustomAttributes)

        // *** End programmer edit section *** (ЗаявкаНаПрактику.Информация CustomAttributes)
        [StrLen(255)]
        public virtual string Информация
        {
            get
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.Информация Get start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.Информация Get start)
                string result = this.fИнформация;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.Информация Get end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.Информация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.Информация Set start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.Информация Set start)
                this.fИнформация = value;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.Информация Set end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.Информация Set end)
            }
        }
        
        /// <summary>
        /// ДатаНачала.
        /// </summary>
        // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала CustomAttributes)

        // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала CustomAttributes)
        public virtual System.DateTime ДатаНачала
        {
            get
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Get start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Get start)
                System.DateTime result = this.fДатаНачала;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Get end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Set start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Set start)
                this.fДатаНачала = value;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Set end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаНачала Set end)
            }
        }
        
        /// <summary>
        /// ДатаКонца.
        /// </summary>
        // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца CustomAttributes)

        // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца CustomAttributes)
        public virtual System.DateTime ДатаКонца
        {
            get
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Get start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Get start)
                System.DateTime result = this.fДатаКонца;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Get end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Set start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Set start)
                this.fДатаКонца = value;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Set end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ДатаКонца Set end)
            }
        }
        
        /// <summary>
        /// Заявка на практику.
        /// </summary>
        // *** Start programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ CustomAttributes)

        // *** End programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ CustomAttributes)
        [NotNull()]
        public virtual IIS.Product_47130.ПредставительОУ ПредставительОУ
        {
            get
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Get start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Get start)
                IIS.Product_47130.ПредставительОУ result = this.fПредставительОУ;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Get end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Set start)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Set start)
                this.fПредставительОУ = value;
                // *** Start programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Set end)

                // *** End programmer edit section *** (ЗаявкаНаПрактику.ПредставительОУ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаявкаНаПрактикуE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаНаПрактикуE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаНаПрактикуE", typeof(IIS.Product_47130.ЗаявкаНаПрактику));
                }
            }
            
            /// <summary>
            /// "ЗаявкаНаПрактикуL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаНаПрактикуL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаНаПрактикуL", typeof(IIS.Product_47130.ЗаявкаНаПрактику));
                }
            }
        }
    }
}

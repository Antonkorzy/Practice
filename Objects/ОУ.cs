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
    /// ОУ.
    /// </summary>
    // *** Start programmer edit section *** (ОУ CustomAttributes)

    // *** End programmer edit section *** (ОУ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОУE", new string[] {
            "Название as \'Название\'",
            "Информация as \'Информация\'",
            "Ссылка as \'Ссылка\'"})]
    [View("ОУL", new string[] {
            "Название as \'Название\'",
            "Информация as \'Информация\'",
            "Ссылка as \'Ссылка\'"})]
    public class ОУ : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private string fИнформация;
        
        private string fСсылка;
        
        // *** Start programmer edit section *** (ОУ CustomMembers)

        // *** End programmer edit section *** (ОУ CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (ОУ.Название CustomAttributes)

        // *** End programmer edit section *** (ОУ.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (ОУ.Название Get start)

                // *** End programmer edit section *** (ОУ.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (ОУ.Название Get end)

                // *** End programmer edit section *** (ОУ.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОУ.Название Set start)

                // *** End programmer edit section *** (ОУ.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (ОУ.Название Set end)

                // *** End programmer edit section *** (ОУ.Название Set end)
            }
        }
        
        /// <summary>
        /// Информация.
        /// </summary>
        // *** Start programmer edit section *** (ОУ.Информация CustomAttributes)

        // *** End programmer edit section *** (ОУ.Информация CustomAttributes)
        [StrLen(255)]
        public virtual string Информация
        {
            get
            {
                // *** Start programmer edit section *** (ОУ.Информация Get start)

                // *** End programmer edit section *** (ОУ.Информация Get start)
                string result = this.fИнформация;
                // *** Start programmer edit section *** (ОУ.Информация Get end)

                // *** End programmer edit section *** (ОУ.Информация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОУ.Информация Set start)

                // *** End programmer edit section *** (ОУ.Информация Set start)
                this.fИнформация = value;
                // *** Start programmer edit section *** (ОУ.Информация Set end)

                // *** End programmer edit section *** (ОУ.Информация Set end)
            }
        }
        
        /// <summary>
        /// Ссылка.
        /// </summary>
        // *** Start programmer edit section *** (ОУ.Ссылка CustomAttributes)

        // *** End programmer edit section *** (ОУ.Ссылка CustomAttributes)
        [StrLen(255)]
        public virtual string Ссылка
        {
            get
            {
                // *** Start programmer edit section *** (ОУ.Ссылка Get start)

                // *** End programmer edit section *** (ОУ.Ссылка Get start)
                string result = this.fСсылка;
                // *** Start programmer edit section *** (ОУ.Ссылка Get end)

                // *** End programmer edit section *** (ОУ.Ссылка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОУ.Ссылка Set start)

                // *** End programmer edit section *** (ОУ.Ссылка Set start)
                this.fСсылка = value;
                // *** Start programmer edit section *** (ОУ.Ссылка Set end)

                // *** End programmer edit section *** (ОУ.Ссылка Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОУE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОУE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОУE", typeof(IIS.Product_47130.ОУ));
                }
            }
            
            /// <summary>
            /// "ОУL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОУL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОУL", typeof(IIS.Product_47130.ОУ));
                }
            }
        }
    }
}

﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_47130
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class КомпанияL : BaseListForm<Компания>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public КомпанияL() : base(Компания.Views.КомпанияL)
        {
            EditPage = КомпанияE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Kompaniya/KompaniyaL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}

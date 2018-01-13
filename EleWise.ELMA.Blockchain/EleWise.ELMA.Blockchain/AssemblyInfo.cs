[assembly: System.Runtime.InteropServices.Guid("264c65f0-fd5b-4498-8cbe-fba530bcdcbd")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Reflection.AssemblyTitle("EleWise.ELMA.Blockchain")]
[assembly: EleWise.ELMA.ComponentModel.ComponentAssembly()]
[assembly: EleWise.ELMA.Model.Attributes.ModelAssembly()]

namespace EleWise.ELMA.Blockchain
{
    using System;
    
    
    [global::EleWise.ELMA.Model.Attributes.MetadataType(typeof(global::EleWise.ELMA.Model.Metadata.AssemblyInfoMetadata))]
    [global::EleWise.ELMA.Model.Attributes.Uid("264c65f0-fd5b-4498-8cbe-fba530bcdcbd")]
    [global::EleWise.ELMA.Model.Attributes.AssemblySummary(typeof(@__Resources__AssemblyInfo), "Summary")]
    internal class @__AssemblyInfo
    {
        
        /// <summary>
        /// Уникальный идентификатор данного класса
        /// </summary>
        public const string UID_S = "264c65f0-fd5b-4498-8cbe-fba530bcdcbd";
        
        private static global::System.Guid _UID = new global::System.Guid(UID_S);
        
        /// <summary>
        /// Уникальный идентификатор данного класса
        /// </summary>
        public static global::System.Guid UID
        {
            get
            {
                return _UID;
            }
        }
    }
    
    internal class @__Resources__AssemblyInfo
    {
        
        public static string DisplayName
        {
            get
            {
                return global::EleWise.ELMA.SR.T("EleWise.ELMA.Blockchain");
            }
        }
        
        public static string Summary
        {
            get
            {
                return global::EleWise.ELMA.SR.T("Блокчейн в Элме для хакатона");
            }
        }
    }
}

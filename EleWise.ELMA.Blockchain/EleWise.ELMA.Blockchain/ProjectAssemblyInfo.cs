[assembly: EleWise.ELMA.Modules.Attributes.AssemblyModule(EleWise.ELMA.Blockchain.__ModuleInfo.UID_S)]

[assembly: EleWise.ELMA.Modules.Attributes.Module(EleWise.ELMA.Blockchain.__ModuleInfo.ModuleId, EleWise.ELMA.Blockchain.__ModuleInfo.UID_S)]
[assembly: EleWise.ELMA.Modules.Attributes.ModuleTitle("EleWise.ELMA.Blockchain")]

namespace EleWise.ELMA.Blockchain
{

    public static class __ModuleInfo
    {
        public const string ModuleId = "EleWise.ELMA.Blockchain";

        public const string UID_S = "be2e3431-a13e-4c3b-a804-fc7fc75d0d60";

        public static readonly System.Guid UID = new System.Guid(UID_S);

        public static string LocalizedName = EleWise.ELMA.SR.T("EleWise.ELMA.Blockchain");
    }

}
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateGroupAccessControlEntryAccessRightsFactory(Action<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights>
{

    protected override Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights Create()
    {
        var accessRightsResult = CreateAccessRights();
        factoryAction?.Invoke(accessRightsResult);

        return accessRightsResult;
    }

    private Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights CreateAccessRights()
    {
        var accessRightsResult = new Humidifier.PCAConnectorAD.TemplateGroupAccessControlEntryTypes.AccessRights();

        return accessRightsResult;
    }

} // End Of Class

public static class InnerTemplateGroupAccessControlEntryAccessRightsFactoryExtensions
{
}

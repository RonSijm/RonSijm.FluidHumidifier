// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowModuleVersionFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlowModuleVersion> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlowModuleVersion>(resourceName)
{

    protected override Humidifier.Connect.ContactFlowModuleVersion Create()
    {
        var contactFlowModuleVersionResult = CreateContactFlowModuleVersion();
        factoryAction?.Invoke(contactFlowModuleVersionResult);

        return contactFlowModuleVersionResult;
    }

    private Humidifier.Connect.ContactFlowModuleVersion CreateContactFlowModuleVersion()
    {
        var contactFlowModuleVersionResult = new Humidifier.Connect.ContactFlowModuleVersion
        {
            GivenName = InputResourceName,
        };

        return contactFlowModuleVersionResult;
    }

} // End Of Class

public static class ContactFlowModuleVersionFactoryExtensions
{
}

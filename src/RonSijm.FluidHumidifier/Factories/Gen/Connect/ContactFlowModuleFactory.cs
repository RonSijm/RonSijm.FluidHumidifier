// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowModuleFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlowModule> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlowModule>(resourceName)
{

    protected override Humidifier.Connect.ContactFlowModule Create()
    {
        var contactFlowModuleResult = CreateContactFlowModule();
        factoryAction?.Invoke(contactFlowModuleResult);

        return contactFlowModuleResult;
    }

    private Humidifier.Connect.ContactFlowModule CreateContactFlowModule()
    {
        var contactFlowModuleResult = new Humidifier.Connect.ContactFlowModule
        {
            GivenName = InputResourceName,
        };

        return contactFlowModuleResult;
    }

} // End Of Class

public static class ContactFlowModuleFactoryExtensions
{
}

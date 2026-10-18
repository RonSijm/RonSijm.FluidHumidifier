// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowVersionFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlowVersion> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlowVersion>(resourceName)
{

    protected override Humidifier.Connect.ContactFlowVersion Create()
    {
        var contactFlowVersionResult = CreateContactFlowVersion();
        factoryAction?.Invoke(contactFlowVersionResult);

        return contactFlowVersionResult;
    }

    private Humidifier.Connect.ContactFlowVersion CreateContactFlowVersion()
    {
        var contactFlowVersionResult = new Humidifier.Connect.ContactFlowVersion
        {
            GivenName = InputResourceName,
        };

        return contactFlowVersionResult;
    }

} // End Of Class

public static class ContactFlowVersionFactoryExtensions
{
}

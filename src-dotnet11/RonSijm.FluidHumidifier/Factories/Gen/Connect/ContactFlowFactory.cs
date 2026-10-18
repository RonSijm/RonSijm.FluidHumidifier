// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlow> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlow>(resourceName)
{

    protected override Humidifier.Connect.ContactFlow Create()
    {
        var contactFlowResult = CreateContactFlow();
        factoryAction?.Invoke(contactFlowResult);

        return contactFlowResult;
    }

    private Humidifier.Connect.ContactFlow CreateContactFlow()
    {
        var contactFlowResult = new Humidifier.Connect.ContactFlow
        {
            GivenName = InputResourceName,
        };

        return contactFlowResult;
    }

} // End Of Class

public static class ContactFlowFactoryExtensions
{
}

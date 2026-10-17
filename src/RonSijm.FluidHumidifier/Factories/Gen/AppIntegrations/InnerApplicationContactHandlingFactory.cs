// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerApplicationContactHandlingFactory(Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling>
{

    protected override Humidifier.AppIntegrations.ApplicationTypes.ContactHandling Create()
    {
        var contactHandlingResult = CreateContactHandling();
        factoryAction?.Invoke(contactHandlingResult);

        return contactHandlingResult;
    }

    private Humidifier.AppIntegrations.ApplicationTypes.ContactHandling CreateContactHandling()
    {
        var contactHandlingResult = new Humidifier.AppIntegrations.ApplicationTypes.ContactHandling();

        return contactHandlingResult;
    }

} // End Of Class

public static class InnerApplicationContactHandlingFactoryExtensions
{
}

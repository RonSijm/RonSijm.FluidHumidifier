// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class ApplicationProviderFactory(string resourceName = null, Action<Humidifier.SSO.ApplicationProvider> factoryAction = null) : ResourceFactory<Humidifier.SSO.ApplicationProvider>(resourceName)
{

    protected override Humidifier.SSO.ApplicationProvider Create()
    {
        var applicationProviderResult = CreateApplicationProvider();
        factoryAction?.Invoke(applicationProviderResult);

        return applicationProviderResult;
    }

    private Humidifier.SSO.ApplicationProvider CreateApplicationProvider()
    {
        var applicationProviderResult = new Humidifier.SSO.ApplicationProvider
        {
            GivenName = InputResourceName,
        };

        return applicationProviderResult;
    }

} // End Of Class

public static class ApplicationProviderFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackUrlRedirectionConfigFactory(Action<Humidifier.AppStream.StackTypes.UrlRedirectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.UrlRedirectionConfig>
{

    protected override Humidifier.AppStream.StackTypes.UrlRedirectionConfig Create()
    {
        var urlRedirectionConfigResult = CreateUrlRedirectionConfig();
        factoryAction?.Invoke(urlRedirectionConfigResult);

        return urlRedirectionConfigResult;
    }

    private Humidifier.AppStream.StackTypes.UrlRedirectionConfig CreateUrlRedirectionConfig()
    {
        var urlRedirectionConfigResult = new Humidifier.AppStream.StackTypes.UrlRedirectionConfig();

        return urlRedirectionConfigResult;
    }

} // End Of Class

public static class InnerStackUrlRedirectionConfigFactoryExtensions
{
}

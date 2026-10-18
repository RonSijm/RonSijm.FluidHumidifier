// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class AccessSourceFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.AccessSource> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.AccessSource>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.AccessSource Create()
    {
        var accessSourceResult = CreateAccessSource();
        factoryAction?.Invoke(accessSourceResult);

        return accessSourceResult;
    }

    private Humidifier.Route53GlobalResolver.AccessSource CreateAccessSource()
    {
        var accessSourceResult = new Humidifier.Route53GlobalResolver.AccessSource
        {
            GivenName = InputResourceName,
        };

        return accessSourceResult;
    }

} // End Of Class

public static class AccessSourceFactoryExtensions
{
}

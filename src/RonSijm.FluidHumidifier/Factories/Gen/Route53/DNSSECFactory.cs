// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class DNSSECFactory(string resourceName = null, Action<Humidifier.Route53.DNSSEC> factoryAction = null) : ResourceFactory<Humidifier.Route53.DNSSEC>(resourceName)
{

    protected override Humidifier.Route53.DNSSEC Create()
    {
        var dNSSECResult = CreateDNSSEC();
        factoryAction?.Invoke(dNSSECResult);

        return dNSSECResult;
    }

    private Humidifier.Route53.DNSSEC CreateDNSSEC()
    {
        var dNSSECResult = new Humidifier.Route53.DNSSEC
        {
            GivenName = InputResourceName,
        };

        return dNSSECResult;
    }

} // End Of Class

public static class DNSSECFactoryExtensions
{
}

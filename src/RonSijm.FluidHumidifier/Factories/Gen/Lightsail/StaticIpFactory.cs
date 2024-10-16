// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class StaticIpFactory(string resourceName = null, Action<Humidifier.Lightsail.StaticIp> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.StaticIp>(resourceName)
{

    protected override Humidifier.Lightsail.StaticIp Create()
    {
        var staticIpResult = CreateStaticIp();
        factoryAction?.Invoke(staticIpResult);

        return staticIpResult;
    }

    private Humidifier.Lightsail.StaticIp CreateStaticIp()
    {
        var staticIpResult = new Humidifier.Lightsail.StaticIp
        {
            GivenName = InputResourceName,
        };

        return staticIpResult;
    }

} // End Of Class

public static class StaticIpFactoryExtensions
{
}

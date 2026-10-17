// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashTtmlConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration Create()
    {
        var dashTtmlConfigurationResult = CreateDashTtmlConfiguration();
        factoryAction?.Invoke(dashTtmlConfigurationResult);

        return dashTtmlConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration CreateDashTtmlConfiguration()
    {
        var dashTtmlConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashTtmlConfiguration();

        return dashTtmlConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointDashTtmlConfigurationFactoryExtensions
{
}

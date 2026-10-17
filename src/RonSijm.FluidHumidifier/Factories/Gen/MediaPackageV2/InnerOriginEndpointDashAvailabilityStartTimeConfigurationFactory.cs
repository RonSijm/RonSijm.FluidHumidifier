// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashAvailabilityStartTimeConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration Create()
    {
        var dashAvailabilityStartTimeConfigurationResult = CreateDashAvailabilityStartTimeConfiguration();
        factoryAction?.Invoke(dashAvailabilityStartTimeConfigurationResult);

        return dashAvailabilityStartTimeConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration CreateDashAvailabilityStartTimeConfiguration()
    {
        var dashAvailabilityStartTimeConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashAvailabilityStartTimeConfiguration();

        return dashAvailabilityStartTimeConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointDashAvailabilityStartTimeConfigurationFactoryExtensions
{
}

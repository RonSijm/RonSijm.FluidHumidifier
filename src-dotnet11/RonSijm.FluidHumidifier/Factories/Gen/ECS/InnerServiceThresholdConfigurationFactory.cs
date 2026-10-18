// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceThresholdConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ThresholdConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.ThresholdConfiguration Create()
    {
        var thresholdConfigurationResult = CreateThresholdConfiguration();
        factoryAction?.Invoke(thresholdConfigurationResult);

        return thresholdConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.ThresholdConfiguration CreateThresholdConfiguration()
    {
        var thresholdConfigurationResult = new Humidifier.ECS.ServiceTypes.ThresholdConfiguration();

        return thresholdConfigurationResult;
    }

} // End Of Class

public static class InnerServiceThresholdConfigurationFactoryExtensions
{
}

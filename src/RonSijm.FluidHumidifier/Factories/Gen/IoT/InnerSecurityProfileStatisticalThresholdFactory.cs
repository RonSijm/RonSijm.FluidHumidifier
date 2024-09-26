// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileStatisticalThresholdFactory(Action<Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold>
{

    protected override Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold Create()
    {
        var statisticalThresholdResult = CreateStatisticalThreshold();
        factoryAction?.Invoke(statisticalThresholdResult);

        return statisticalThresholdResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold CreateStatisticalThreshold()
    {
        var statisticalThresholdResult = new Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold();

        return statisticalThresholdResult;
    }

} // End Of Class

public static class InnerSecurityProfileStatisticalThresholdFactoryExtensions
{
}

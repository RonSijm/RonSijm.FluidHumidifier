// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotFleetTargetGroupsConfigFactory(Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig>
{

    protected override Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig Create()
    {
        var targetGroupsConfigResult = CreateTargetGroupsConfig();
        factoryAction?.Invoke(targetGroupsConfigResult);

        return targetGroupsConfigResult;
    }

    private Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig CreateTargetGroupsConfig()
    {
        var targetGroupsConfigResult = new Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig();

        return targetGroupsConfigResult;
    }

} // End Of Class

public static class InnerSpotFleetTargetGroupsConfigFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupScalingConfigFactory(Action<Humidifier.EKS.NodegroupTypes.ScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.ScalingConfig>
{

    protected override Humidifier.EKS.NodegroupTypes.ScalingConfig Create()
    {
        var scalingConfigResult = CreateScalingConfig();
        factoryAction?.Invoke(scalingConfigResult);

        return scalingConfigResult;
    }

    private Humidifier.EKS.NodegroupTypes.ScalingConfig CreateScalingConfig()
    {
        var scalingConfigResult = new Humidifier.EKS.NodegroupTypes.ScalingConfig();

        return scalingConfigResult;
    }

} // End Of Class

public static class InnerNodegroupScalingConfigFactoryExtensions
{
}

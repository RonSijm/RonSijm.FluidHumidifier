// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupScalingConfigurationFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration Create()
    {
        var scalingConfigurationResult = CreateScalingConfiguration();
        factoryAction?.Invoke(scalingConfigurationResult);

        return scalingConfigurationResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration CreateScalingConfiguration()
    {
        var scalingConfigurationResult = new Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration();

        return scalingConfigurationResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupScalingConfigurationFactoryExtensions
{
}

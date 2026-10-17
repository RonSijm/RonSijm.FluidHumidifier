// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterControlPlaneScalingConfigFactory(Action<Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig>
{

    protected override Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig Create()
    {
        var controlPlaneScalingConfigResult = CreateControlPlaneScalingConfig();
        factoryAction?.Invoke(controlPlaneScalingConfigResult);

        return controlPlaneScalingConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig CreateControlPlaneScalingConfig()
    {
        var controlPlaneScalingConfigResult = new Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig();

        return controlPlaneScalingConfigResult;
    }

} // End Of Class

public static class InnerClusterControlPlaneScalingConfigFactoryExtensions
{
}

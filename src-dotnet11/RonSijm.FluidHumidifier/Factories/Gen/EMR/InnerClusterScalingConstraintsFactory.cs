// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterScalingConstraintsFactory(Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.ScalingConstraints>
{

    protected override Humidifier.EMR.ClusterTypes.ScalingConstraints Create()
    {
        var scalingConstraintsResult = CreateScalingConstraints();
        factoryAction?.Invoke(scalingConstraintsResult);

        return scalingConstraintsResult;
    }

    private Humidifier.EMR.ClusterTypes.ScalingConstraints CreateScalingConstraints()
    {
        var scalingConstraintsResult = new Humidifier.EMR.ClusterTypes.ScalingConstraints();

        return scalingConstraintsResult;
    }

} // End Of Class

public static class InnerClusterScalingConstraintsFactoryExtensions
{
}

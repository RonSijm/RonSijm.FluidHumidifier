// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceGroupConfigScalingConstraintsFactory(Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints>
{

    protected override Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints Create()
    {
        var scalingConstraintsResult = CreateScalingConstraints();
        factoryAction?.Invoke(scalingConstraintsResult);

        return scalingConstraintsResult;
    }

    private Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints CreateScalingConstraints()
    {
        var scalingConstraintsResult = new Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints();

        return scalingConstraintsResult;
    }

} // End Of Class

public static class InnerInstanceGroupConfigScalingConstraintsFactoryExtensions
{
}

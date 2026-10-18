// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupTrafficSourceIdentifierFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier Create()
    {
        var trafficSourceIdentifierResult = CreateTrafficSourceIdentifier();
        factoryAction?.Invoke(trafficSourceIdentifierResult);

        return trafficSourceIdentifierResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier CreateTrafficSourceIdentifier()
    {
        var trafficSourceIdentifierResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier();

        return trafficSourceIdentifierResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupTrafficSourceIdentifierFactoryExtensions
{
}

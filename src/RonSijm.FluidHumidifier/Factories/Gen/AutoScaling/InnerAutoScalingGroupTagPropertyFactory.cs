// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupTagPropertyFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty Create()
    {
        var tagPropertyResult = CreateTagProperty();
        factoryAction?.Invoke(tagPropertyResult);

        return tagPropertyResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty CreateTagProperty()
    {
        var tagPropertyResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty();

        return tagPropertyResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupTagPropertyFactoryExtensions
{
}

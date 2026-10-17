// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupRetentionTriggersFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers Create()
    {
        var retentionTriggersResult = CreateRetentionTriggers();
        factoryAction?.Invoke(retentionTriggersResult);

        return retentionTriggersResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers CreateRetentionTriggers()
    {
        var retentionTriggersResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers();

        return retentionTriggersResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupRetentionTriggersFactoryExtensions
{
}

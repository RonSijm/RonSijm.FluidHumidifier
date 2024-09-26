// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerScalingPolicyStepAdjustmentFactory(Action<Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment>
{

    protected override Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment Create()
    {
        var stepAdjustmentResult = CreateStepAdjustment();
        factoryAction?.Invoke(stepAdjustmentResult);

        return stepAdjustmentResult;
    }

    private Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment CreateStepAdjustment()
    {
        var stepAdjustmentResult = new Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment();

        return stepAdjustmentResult;
    }

} // End Of Class

public static class InnerScalingPolicyStepAdjustmentFactoryExtensions
{
}

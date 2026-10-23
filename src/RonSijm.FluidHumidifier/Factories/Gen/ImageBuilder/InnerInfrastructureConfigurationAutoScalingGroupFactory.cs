// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationAutoScalingGroupFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup>
{

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup Create()
    {
        var autoScalingGroupResult = CreateAutoScalingGroup();
        factoryAction?.Invoke(autoScalingGroupResult);

        return autoScalingGroupResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup CreateAutoScalingGroup()
    {
        var autoScalingGroupResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.AutoScalingGroup();

        return autoScalingGroupResult;
    }

} // End Of Class

public static class InnerInfrastructureConfigurationAutoScalingGroupFactoryExtensions
{
}

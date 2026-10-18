// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class AutoScalingConfigurationFactory(string resourceName = null, Action<Humidifier.AppRunner.AutoScalingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.AppRunner.AutoScalingConfiguration>(resourceName)
{

    protected override Humidifier.AppRunner.AutoScalingConfiguration Create()
    {
        var autoScalingConfigurationResult = CreateAutoScalingConfiguration();
        factoryAction?.Invoke(autoScalingConfigurationResult);

        return autoScalingConfigurationResult;
    }

    private Humidifier.AppRunner.AutoScalingConfiguration CreateAutoScalingConfiguration()
    {
        var autoScalingConfigurationResult = new Humidifier.AppRunner.AutoScalingConfiguration
        {
            GivenName = InputResourceName,
        };

        return autoScalingConfigurationResult;
    }

} // End Of Class

public static class AutoScalingConfigurationFactoryExtensions
{
}

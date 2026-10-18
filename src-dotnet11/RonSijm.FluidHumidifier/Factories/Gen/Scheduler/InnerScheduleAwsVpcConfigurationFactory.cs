// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleAwsVpcConfigurationFactory(Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration>
{

    protected override Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration Create()
    {
        var awsVpcConfigurationResult = CreateAwsVpcConfiguration();
        factoryAction?.Invoke(awsVpcConfigurationResult);

        return awsVpcConfigurationResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration CreateAwsVpcConfiguration()
    {
        var awsVpcConfigurationResult = new Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration();

        return awsVpcConfigurationResult;
    }

} // End Of Class

public static class InnerScheduleAwsVpcConfigurationFactoryExtensions
{
}

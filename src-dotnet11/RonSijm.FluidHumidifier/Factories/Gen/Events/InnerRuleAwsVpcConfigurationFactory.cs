// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleAwsVpcConfigurationFactory(Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.AwsVpcConfiguration>
{

    protected override Humidifier.Events.RuleTypes.AwsVpcConfiguration Create()
    {
        var awsVpcConfigurationResult = CreateAwsVpcConfiguration();
        factoryAction?.Invoke(awsVpcConfigurationResult);

        return awsVpcConfigurationResult;
    }

    private Humidifier.Events.RuleTypes.AwsVpcConfiguration CreateAwsVpcConfiguration()
    {
        var awsVpcConfigurationResult = new Humidifier.Events.RuleTypes.AwsVpcConfiguration();

        return awsVpcConfigurationResult;
    }

} // End Of Class

public static class InnerRuleAwsVpcConfigurationFactoryExtensions
{
}

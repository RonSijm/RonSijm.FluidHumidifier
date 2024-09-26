// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceAwsVpcConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.AwsVpcConfiguration Create()
    {
        var awsVpcConfigurationResult = CreateAwsVpcConfiguration();
        factoryAction?.Invoke(awsVpcConfigurationResult);

        return awsVpcConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.AwsVpcConfiguration CreateAwsVpcConfiguration()
    {
        var awsVpcConfigurationResult = new Humidifier.ECS.ServiceTypes.AwsVpcConfiguration();

        return awsVpcConfigurationResult;
    }

} // End Of Class

public static class InnerServiceAwsVpcConfigurationFactoryExtensions
{
}

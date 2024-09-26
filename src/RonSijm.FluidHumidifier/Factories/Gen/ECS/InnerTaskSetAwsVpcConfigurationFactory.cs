// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetAwsVpcConfigurationFactory(Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration>
{

    protected override Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration Create()
    {
        var awsVpcConfigurationResult = CreateAwsVpcConfiguration();
        factoryAction?.Invoke(awsVpcConfigurationResult);

        return awsVpcConfigurationResult;
    }

    private Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration CreateAwsVpcConfiguration()
    {
        var awsVpcConfigurationResult = new Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration();

        return awsVpcConfigurationResult;
    }

} // End Of Class

public static class InnerTaskSetAwsVpcConfigurationFactoryExtensions
{
}

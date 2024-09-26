// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeAwsVpcConfigurationFactory(Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration>
{

    protected override Humidifier.Pipes.PipeTypes.AwsVpcConfiguration Create()
    {
        var awsVpcConfigurationResult = CreateAwsVpcConfiguration();
        factoryAction?.Invoke(awsVpcConfigurationResult);

        return awsVpcConfigurationResult;
    }

    private Humidifier.Pipes.PipeTypes.AwsVpcConfiguration CreateAwsVpcConfiguration()
    {
        var awsVpcConfigurationResult = new Humidifier.Pipes.PipeTypes.AwsVpcConfiguration();

        return awsVpcConfigurationResult;
    }

} // End Of Class

public static class InnerPipeAwsVpcConfigurationFactoryExtensions
{
}

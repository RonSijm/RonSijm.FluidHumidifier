// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerChannelFlowLambdaConfigurationFactory(Action<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration>
{

    protected override Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration Create()
    {
        var lambdaConfigurationResult = CreateLambdaConfiguration();
        factoryAction?.Invoke(lambdaConfigurationResult);

        return lambdaConfigurationResult;
    }

    private Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration CreateLambdaConfiguration()
    {
        var lambdaConfigurationResult = new Humidifier.Chime.ChannelFlowTypes.LambdaConfiguration();

        return lambdaConfigurationResult;
    }

} // End Of Class

public static class InnerChannelFlowLambdaConfigurationFactoryExtensions
{
}

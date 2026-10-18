// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeSessionStorageConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration Create()
    {
        var sessionStorageConfigurationResult = CreateSessionStorageConfiguration();
        factoryAction?.Invoke(sessionStorageConfigurationResult);

        return sessionStorageConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration CreateSessionStorageConfiguration()
    {
        var sessionStorageConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.SessionStorageConfiguration();

        return sessionStorageConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeSessionStorageConfigurationFactoryExtensions
{
}

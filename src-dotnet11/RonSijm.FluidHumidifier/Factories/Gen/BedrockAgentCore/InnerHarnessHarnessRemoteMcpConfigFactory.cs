// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessRemoteMcpConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig Create()
    {
        var harnessRemoteMcpConfigResult = CreateHarnessRemoteMcpConfig();
        factoryAction?.Invoke(harnessRemoteMcpConfigResult);

        return harnessRemoteMcpConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig CreateHarnessRemoteMcpConfig()
    {
        var harnessRemoteMcpConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessRemoteMcpConfig();

        return harnessRemoteMcpConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessRemoteMcpConfigFactoryExtensions
{
}

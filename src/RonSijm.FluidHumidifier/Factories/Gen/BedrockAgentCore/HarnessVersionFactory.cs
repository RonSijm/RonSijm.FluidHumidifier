// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class HarnessVersionFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.HarnessVersion> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.HarnessVersion>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.HarnessVersion Create()
    {
        var harnessVersionResult = CreateHarnessVersion();
        factoryAction?.Invoke(harnessVersionResult);

        return harnessVersionResult;
    }

    private Humidifier.BedrockAgentCore.HarnessVersion CreateHarnessVersion()
    {
        var harnessVersionResult = new Humidifier.BedrockAgentCore.HarnessVersion
        {
            GivenName = InputResourceName,
        };

        return harnessVersionResult;
    }

} // End Of Class

public static class HarnessVersionFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class BrowserFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.Browser> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.Browser>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.Browser Create()
    {
        var browserResult = CreateBrowser();
        factoryAction?.Invoke(browserResult);

        return browserResult;
    }

    private Humidifier.BedrockAgentCore.Browser CreateBrowser()
    {
        var browserResult = new Humidifier.BedrockAgentCore.Browser
        {
            GivenName = InputResourceName,
        };

        return browserResult;
    }

} // End Of Class

public static class BrowserFactoryExtensions
{
}

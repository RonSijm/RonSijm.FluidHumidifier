// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class BrowserProfileFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.BrowserProfile> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.BrowserProfile>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.BrowserProfile Create()
    {
        var browserProfileResult = CreateBrowserProfile();
        factoryAction?.Invoke(browserProfileResult);

        return browserProfileResult;
    }

    private Humidifier.BedrockAgentCore.BrowserProfile CreateBrowserProfile()
    {
        var browserProfileResult = new Humidifier.BedrockAgentCore.BrowserProfile
        {
            GivenName = InputResourceName,
        };

        return browserProfileResult;
    }

} // End Of Class

public static class BrowserProfileFactoryExtensions
{
}

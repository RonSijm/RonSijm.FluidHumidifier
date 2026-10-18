// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomBrowserSigningFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning>
{

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning Create()
    {
        var browserSigningResult = CreateBrowserSigning();
        factoryAction?.Invoke(browserSigningResult);

        return browserSigningResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning CreateBrowserSigning()
    {
        var browserSigningResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning();

        return browserSigningResult;
    }

} // End Of Class

public static class InnerBrowserCustomBrowserSigningFactoryExtensions
{
}

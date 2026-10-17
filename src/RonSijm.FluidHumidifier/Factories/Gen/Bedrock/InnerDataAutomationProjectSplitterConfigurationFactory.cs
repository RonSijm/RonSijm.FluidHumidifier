// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectSplitterConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration Create()
    {
        var splitterConfigurationResult = CreateSplitterConfiguration();
        factoryAction?.Invoke(splitterConfigurationResult);

        return splitterConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration CreateSplitterConfiguration()
    {
        var splitterConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.SplitterConfiguration();

        return splitterConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectSplitterConfigurationFactoryExtensions
{
}

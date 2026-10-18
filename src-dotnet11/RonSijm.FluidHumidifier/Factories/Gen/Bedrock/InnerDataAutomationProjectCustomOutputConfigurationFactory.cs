// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectCustomOutputConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration Create()
    {
        var customOutputConfigurationResult = CreateCustomOutputConfiguration();
        factoryAction?.Invoke(customOutputConfigurationResult);

        return customOutputConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration CreateCustomOutputConfiguration()
    {
        var customOutputConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.CustomOutputConfiguration();

        return customOutputConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectCustomOutputConfigurationFactoryExtensions
{
}

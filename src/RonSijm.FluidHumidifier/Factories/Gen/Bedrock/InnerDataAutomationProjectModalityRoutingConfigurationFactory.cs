// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectModalityRoutingConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration Create()
    {
        var modalityRoutingConfigurationResult = CreateModalityRoutingConfiguration();
        factoryAction?.Invoke(modalityRoutingConfigurationResult);

        return modalityRoutingConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration CreateModalityRoutingConfiguration()
    {
        var modalityRoutingConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ModalityRoutingConfiguration();

        return modalityRoutingConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectModalityRoutingConfigurationFactoryExtensions
{
}

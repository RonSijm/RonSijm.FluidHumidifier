// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectModalityProcessingConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration Create()
    {
        var modalityProcessingConfigurationResult = CreateModalityProcessingConfiguration();
        factoryAction?.Invoke(modalityProcessingConfigurationResult);

        return modalityProcessingConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration CreateModalityProcessingConfiguration()
    {
        var modalityProcessingConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.ModalityProcessingConfiguration();

        return modalityProcessingConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectModalityProcessingConfigurationFactoryExtensions
{
}

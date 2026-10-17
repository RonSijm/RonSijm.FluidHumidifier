// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectPIIEntitiesConfigurationFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration Create()
    {
        var pIIEntitiesConfigurationResult = CreatePIIEntitiesConfiguration();
        factoryAction?.Invoke(pIIEntitiesConfigurationResult);

        return pIIEntitiesConfigurationResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration CreatePIIEntitiesConfiguration()
    {
        var pIIEntitiesConfigurationResult = new Humidifier.Bedrock.DataAutomationProjectTypes.PIIEntitiesConfiguration();

        return pIIEntitiesConfigurationResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectPIIEntitiesConfigurationFactoryExtensions
{
}

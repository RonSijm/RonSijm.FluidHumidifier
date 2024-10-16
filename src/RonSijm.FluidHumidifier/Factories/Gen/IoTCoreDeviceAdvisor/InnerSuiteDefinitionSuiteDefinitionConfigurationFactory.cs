// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTCoreDeviceAdvisor;

public class InnerSuiteDefinitionSuiteDefinitionConfigurationFactory(Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration>
{

    protected override Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration Create()
    {
        var suiteDefinitionConfigurationResult = CreateSuiteDefinitionConfiguration();
        factoryAction?.Invoke(suiteDefinitionConfigurationResult);

        return suiteDefinitionConfigurationResult;
    }

    private Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration CreateSuiteDefinitionConfiguration()
    {
        var suiteDefinitionConfigurationResult = new Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration();

        return suiteDefinitionConfigurationResult;
    }

} // End Of Class

public static class InnerSuiteDefinitionSuiteDefinitionConfigurationFactoryExtensions
{
}

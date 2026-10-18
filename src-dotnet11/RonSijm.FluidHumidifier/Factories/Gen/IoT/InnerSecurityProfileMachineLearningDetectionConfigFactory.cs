// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileMachineLearningDetectionConfigFactory(Action<Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig>
{

    protected override Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig Create()
    {
        var machineLearningDetectionConfigResult = CreateMachineLearningDetectionConfig();
        factoryAction?.Invoke(machineLearningDetectionConfigResult);

        return machineLearningDetectionConfigResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig CreateMachineLearningDetectionConfig()
    {
        var machineLearningDetectionConfigResult = new Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig();

        return machineLearningDetectionConfigResult;
    }

} // End Of Class

public static class InnerSecurityProfileMachineLearningDetectionConfigFactoryExtensions
{
}

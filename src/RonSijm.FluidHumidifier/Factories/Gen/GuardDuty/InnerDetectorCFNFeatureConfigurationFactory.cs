// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorCFNFeatureConfigurationFactory(Action<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration>
{

    protected override Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration Create()
    {
        var cFNFeatureConfigurationResult = CreateCFNFeatureConfiguration();
        factoryAction?.Invoke(cFNFeatureConfigurationResult);

        return cFNFeatureConfigurationResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration CreateCFNFeatureConfiguration()
    {
        var cFNFeatureConfigurationResult = new Humidifier.GuardDuty.DetectorTypes.CFNFeatureConfiguration();

        return cFNFeatureConfigurationResult;
    }

} // End Of Class

public static class InnerDetectorCFNFeatureConfigurationFactoryExtensions
{
}

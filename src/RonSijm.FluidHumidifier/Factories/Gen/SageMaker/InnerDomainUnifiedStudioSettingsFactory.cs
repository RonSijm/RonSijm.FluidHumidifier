// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainUnifiedStudioSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings Create()
    {
        var unifiedStudioSettingsResult = CreateUnifiedStudioSettings();
        factoryAction?.Invoke(unifiedStudioSettingsResult);

        return unifiedStudioSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings CreateUnifiedStudioSettings()
    {
        var unifiedStudioSettingsResult = new Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings();

        return unifiedStudioSettingsResult;
    }

} // End Of Class

public static class InnerDomainUnifiedStudioSettingsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerExperimentRunTreatmentOverridesFactory(Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides>
{

    protected override Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides Create()
    {
        var treatmentOverridesResult = CreateTreatmentOverrides();
        factoryAction?.Invoke(treatmentOverridesResult);

        return treatmentOverridesResult;
    }

    private Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides CreateTreatmentOverrides()
    {
        var treatmentOverridesResult = new Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides();

        return treatmentOverridesResult;
    }

} // End Of Class

public static class InnerExperimentRunTreatmentOverridesFactoryExtensions
{
}

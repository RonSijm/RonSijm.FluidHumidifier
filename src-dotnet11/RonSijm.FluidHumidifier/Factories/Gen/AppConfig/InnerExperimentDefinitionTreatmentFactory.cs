// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerExperimentDefinitionTreatmentFactory(Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment>
{

    protected override Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment Create()
    {
        var treatmentResult = CreateTreatment();
        factoryAction?.Invoke(treatmentResult);

        return treatmentResult;
    }

    private Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment CreateTreatment()
    {
        var treatmentResult = new Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment();

        return treatmentResult;
    }

} // End Of Class

public static class InnerExperimentDefinitionTreatmentFactoryExtensions
{
}

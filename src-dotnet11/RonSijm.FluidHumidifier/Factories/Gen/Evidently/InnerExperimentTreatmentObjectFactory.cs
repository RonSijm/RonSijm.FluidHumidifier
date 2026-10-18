// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerExperimentTreatmentObjectFactory(Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ExperimentTypes.TreatmentObject>
{

    protected override Humidifier.Evidently.ExperimentTypes.TreatmentObject Create()
    {
        var treatmentObjectResult = CreateTreatmentObject();
        factoryAction?.Invoke(treatmentObjectResult);

        return treatmentObjectResult;
    }

    private Humidifier.Evidently.ExperimentTypes.TreatmentObject CreateTreatmentObject()
    {
        var treatmentObjectResult = new Humidifier.Evidently.ExperimentTypes.TreatmentObject();

        return treatmentObjectResult;
    }

} // End Of Class

public static class InnerExperimentTreatmentObjectFactoryExtensions
{
}

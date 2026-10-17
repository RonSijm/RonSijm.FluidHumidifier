// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class AppAssessmentFactory(string resourceName = null, Action<Humidifier.ResilienceHub.AppAssessment> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHub.AppAssessment>(resourceName)
{

    protected override Humidifier.ResilienceHub.AppAssessment Create()
    {
        var appAssessmentResult = CreateAppAssessment();
        factoryAction?.Invoke(appAssessmentResult);

        return appAssessmentResult;
    }

    private Humidifier.ResilienceHub.AppAssessment CreateAppAssessment()
    {
        var appAssessmentResult = new Humidifier.ResilienceHub.AppAssessment
        {
            GivenName = InputResourceName,
        };

        return appAssessmentResult;
    }

} // End Of Class

public static class AppAssessmentFactoryExtensions
{
}

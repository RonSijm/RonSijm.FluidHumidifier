// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerPiiEntitiesDetectionJobRedactionConfigFactory(Action<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig>
{

    protected override Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig Create()
    {
        var redactionConfigResult = CreateRedactionConfig();
        factoryAction?.Invoke(redactionConfigResult);

        return redactionConfigResult;
    }

    private Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig CreateRedactionConfig()
    {
        var redactionConfigResult = new Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.RedactionConfig();

        return redactionConfigResult;
    }

} // End Of Class

public static class InnerPiiEntitiesDetectionJobRedactionConfigFactoryExtensions
{
}

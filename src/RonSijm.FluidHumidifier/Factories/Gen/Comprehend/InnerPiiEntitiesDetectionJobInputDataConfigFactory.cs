// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerPiiEntitiesDetectionJobInputDataConfigFactory(Action<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerPiiEntitiesDetectionJobInputDataConfigFactoryExtensions
{
}

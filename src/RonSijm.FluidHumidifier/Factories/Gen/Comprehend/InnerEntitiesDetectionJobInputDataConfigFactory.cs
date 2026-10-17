// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerEntitiesDetectionJobInputDataConfigFactory(Action<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerEntitiesDetectionJobInputDataConfigFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentEcsSettingsFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings Create()
    {
        var ecsSettingsResult = CreateEcsSettings();
        factoryAction?.Invoke(ecsSettingsResult);

        return ecsSettingsResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings CreateEcsSettings()
    {
        var ecsSettingsResult = new Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings();

        return ecsSettingsResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentEcsSettingsFactoryExtensions
{
}

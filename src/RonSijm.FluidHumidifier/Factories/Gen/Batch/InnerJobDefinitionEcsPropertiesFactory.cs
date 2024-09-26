// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionEcsPropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.EcsProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.EcsProperties>
{

    protected override Humidifier.Batch.JobDefinitionTypes.EcsProperties Create()
    {
        var ecsPropertiesResult = CreateEcsProperties();
        factoryAction?.Invoke(ecsPropertiesResult);

        return ecsPropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.EcsProperties CreateEcsProperties()
    {
        var ecsPropertiesResult = new Humidifier.Batch.JobDefinitionTypes.EcsProperties();

        return ecsPropertiesResult;
    }

} // End Of Class

public static class InnerJobDefinitionEcsPropertiesFactoryExtensions
{
}

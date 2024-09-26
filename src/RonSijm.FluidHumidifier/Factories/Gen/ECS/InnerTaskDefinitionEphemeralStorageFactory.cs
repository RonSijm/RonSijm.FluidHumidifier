// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionEphemeralStorageFactory(Action<Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage Create()
    {
        var ephemeralStorageResult = CreateEphemeralStorage();
        factoryAction?.Invoke(ephemeralStorageResult);

        return ephemeralStorageResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage CreateEphemeralStorage()
    {
        var ephemeralStorageResult = new Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage();

        return ephemeralStorageResult;
    }

} // End Of Class

public static class InnerTaskDefinitionEphemeralStorageFactoryExtensions
{
}

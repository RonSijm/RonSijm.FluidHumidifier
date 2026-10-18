// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeEcsEphemeralStorageFactory(Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage>
{

    protected override Humidifier.Pipes.PipeTypes.EcsEphemeralStorage Create()
    {
        var ecsEphemeralStorageResult = CreateEcsEphemeralStorage();
        factoryAction?.Invoke(ecsEphemeralStorageResult);

        return ecsEphemeralStorageResult;
    }

    private Humidifier.Pipes.PipeTypes.EcsEphemeralStorage CreateEcsEphemeralStorage()
    {
        var ecsEphemeralStorageResult = new Humidifier.Pipes.PipeTypes.EcsEphemeralStorage();

        return ecsEphemeralStorageResult;
    }

} // End Of Class

public static class InnerPipeEcsEphemeralStorageFactoryExtensions
{
}

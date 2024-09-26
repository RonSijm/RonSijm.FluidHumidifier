// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeEcsTaskOverrideFactory(Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.EcsTaskOverride>
{

    internal InnerPipeEcsEphemeralStorageFactory EphemeralStorageFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.EcsTaskOverride Create()
    {
        var ecsTaskOverrideResult = CreateEcsTaskOverride();
        factoryAction?.Invoke(ecsTaskOverrideResult);

        return ecsTaskOverrideResult;
    }

    private Humidifier.Pipes.PipeTypes.EcsTaskOverride CreateEcsTaskOverride()
    {
        var ecsTaskOverrideResult = new Humidifier.Pipes.PipeTypes.EcsTaskOverride();

        return ecsTaskOverrideResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.EcsTaskOverride result)
    {
        base.CreateChildren(result);

        result.EphemeralStorage ??= EphemeralStorageFactory?.Build();
    }

} // End Of Class

public static class InnerPipeEcsTaskOverrideFactoryExtensions
{
    public static CombinedResult<InnerPipeEcsTaskOverrideFactory, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage(this InnerPipeEcsTaskOverrideFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null)
    {
        parentFactory.EphemeralStorageFactory = new InnerPipeEcsEphemeralStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EphemeralStorageFactory);
    }

    public static CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1>(this CombinedResult<InnerPipeEcsTaskOverrideFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1>(this CombinedResult<T1, InnerPipeEcsTaskOverrideFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2>(this CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2>(this CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2>(this CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2, T3, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3>(this CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2, T3, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3>(this CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory, T3, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipeEcsTaskOverrideFactory, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipeEcsTaskOverrideFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2, T3, T4, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3, T4>(this CombinedResult<InnerPipeEcsTaskOverrideFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2, T3, T4, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipeEcsTaskOverrideFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory, T3, T4, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipeEcsTaskOverrideFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipeEcsTaskOverrideFactory, T4, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipeEcsTaskOverrideFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipeEcsTaskOverrideFactory, InnerPipeEcsEphemeralStorageFactory> WithEphemeralStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipeEcsTaskOverrideFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsEphemeralStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorage(combinedResult.T5, subFactoryAction));
}

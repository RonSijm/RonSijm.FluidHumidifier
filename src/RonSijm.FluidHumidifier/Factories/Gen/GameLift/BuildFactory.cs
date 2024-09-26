// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class BuildFactory(string resourceName = null, Action<Humidifier.GameLift.Build> factoryAction = null) : ResourceFactory<Humidifier.GameLift.Build>(resourceName)
{

    internal InnerBuildStorageLocationFactory StorageLocationFactory { get; set; }

    protected override Humidifier.GameLift.Build Create()
    {
        var buildResult = CreateBuild();
        factoryAction?.Invoke(buildResult);

        return buildResult;
    }

    private Humidifier.GameLift.Build CreateBuild()
    {
        var buildResult = new Humidifier.GameLift.Build
        {
            GivenName = InputResourceName,
        };

        return buildResult;
    }
    public override void CreateChildren(Humidifier.GameLift.Build result)
    {
        base.CreateChildren(result);

        result.StorageLocation ??= StorageLocationFactory?.Build();
    }

} // End Of Class

public static class BuildFactoryExtensions
{
    public static CombinedResult<BuildFactory, InnerBuildStorageLocationFactory> WithStorageLocation(this BuildFactory parentFactory, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null)
    {
        parentFactory.StorageLocationFactory = new InnerBuildStorageLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageLocationFactory);
    }

    public static CombinedResult<BuildFactory, T1, InnerBuildStorageLocationFactory> WithStorageLocation<T1>(this CombinedResult<BuildFactory, T1> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BuildFactory, InnerBuildStorageLocationFactory> WithStorageLocation<T1>(this CombinedResult<T1, BuildFactory> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BuildFactory, T1, T2, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<BuildFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BuildFactory, T2, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, BuildFactory, T2> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BuildFactory, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2>(this CombinedResult<T1, T2, BuildFactory> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BuildFactory, T1, T2, T3, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<BuildFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BuildFactory, T2, T3, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, BuildFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BuildFactory, T3, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, BuildFactory, T3> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BuildFactory, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, BuildFactory> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BuildFactory, T1, T2, T3, T4, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<BuildFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BuildFactory, T2, T3, T4, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, BuildFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BuildFactory, T3, T4, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, BuildFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BuildFactory, T4, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BuildFactory, T4> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BuildFactory, InnerBuildStorageLocationFactory> WithStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BuildFactory> combinedResult, Action<Humidifier.GameLift.BuildTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLocation(combinedResult.T5, subFactoryAction));
}

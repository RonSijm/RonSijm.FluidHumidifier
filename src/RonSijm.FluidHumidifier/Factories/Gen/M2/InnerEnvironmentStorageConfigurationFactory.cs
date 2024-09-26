// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class InnerEnvironmentStorageConfigurationFactory(Action<Humidifier.M2.EnvironmentTypes.StorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.M2.EnvironmentTypes.StorageConfiguration>
{

    internal InnerEnvironmentEfsStorageConfigurationFactory EfsFactory { get; set; }

    internal InnerEnvironmentFsxStorageConfigurationFactory FsxFactory { get; set; }

    protected override Humidifier.M2.EnvironmentTypes.StorageConfiguration Create()
    {
        var storageConfigurationResult = CreateStorageConfiguration();
        factoryAction?.Invoke(storageConfigurationResult);

        return storageConfigurationResult;
    }

    private Humidifier.M2.EnvironmentTypes.StorageConfiguration CreateStorageConfiguration()
    {
        var storageConfigurationResult = new Humidifier.M2.EnvironmentTypes.StorageConfiguration();

        return storageConfigurationResult;
    }
    public override void CreateChildren(Humidifier.M2.EnvironmentTypes.StorageConfiguration result)
    {
        base.CreateChildren(result);

        result.Efs ??= EfsFactory?.Build();
        result.Fsx ??= FsxFactory?.Build();
    }

} // End Of Class

public static class InnerEnvironmentStorageConfigurationFactoryExtensions
{
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs(this InnerEnvironmentStorageConfigurationFactory parentFactory, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null)
    {
        parentFactory.EfsFactory = new InnerEnvironmentEfsStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EfsFactory);
    }

    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx(this InnerEnvironmentStorageConfigurationFactory parentFactory, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null)
    {
        parentFactory.FsxFactory = new InnerEnvironmentFsxStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FsxFactory);
    }

    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEfs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEfs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, T4, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3, T4>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, T4, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3, T4>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, T4, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, T4, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentEfsStorageConfigurationFactory> WithEfs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEfs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFsx(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFsx(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, T4, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3, T4>(this CombinedResult<InnerEnvironmentStorageConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, T4, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3, T4>(this CombinedResult<T1, InnerEnvironmentStorageConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, T4, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEnvironmentStorageConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, T4, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEnvironmentStorageConfigurationFactory, T4> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory, InnerEnvironmentFsxStorageConfigurationFactory> WithFsx<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEnvironmentStorageConfigurationFactory> combinedResult, Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFsx(combinedResult.T5, subFactoryAction));
}

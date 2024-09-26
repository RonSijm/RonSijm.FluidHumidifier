// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class KeyGroupFactory(string resourceName = null, Action<Humidifier.CloudFront.KeyGroup> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.KeyGroup>(resourceName)
{

    internal InnerKeyGroupKeyGroupConfigFactory KeyGroupConfigFactory { get; set; }

    protected override Humidifier.CloudFront.KeyGroup Create()
    {
        var keyGroupResult = CreateKeyGroup();
        factoryAction?.Invoke(keyGroupResult);

        return keyGroupResult;
    }

    private Humidifier.CloudFront.KeyGroup CreateKeyGroup()
    {
        var keyGroupResult = new Humidifier.CloudFront.KeyGroup
        {
            GivenName = InputResourceName,
        };

        return keyGroupResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.KeyGroup result)
    {
        base.CreateChildren(result);

        result.KeyGroupConfig ??= KeyGroupConfigFactory?.Build();
    }

} // End Of Class

public static class KeyGroupFactoryExtensions
{
    public static CombinedResult<KeyGroupFactory, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig(this KeyGroupFactory parentFactory, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null)
    {
        parentFactory.KeyGroupConfigFactory = new InnerKeyGroupKeyGroupConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyGroupConfigFactory);
    }

    public static CombinedResult<KeyGroupFactory, T1, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1>(this CombinedResult<KeyGroupFactory, T1> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyGroupFactory, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1>(this CombinedResult<T1, KeyGroupFactory> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KeyGroupFactory, T1, T2, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2>(this CombinedResult<KeyGroupFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyGroupFactory, T2, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2>(this CombinedResult<T1, KeyGroupFactory, T2> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyGroupFactory, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2>(this CombinedResult<T1, T2, KeyGroupFactory> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KeyGroupFactory, T1, T2, T3, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3>(this CombinedResult<KeyGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyGroupFactory, T2, T3, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3>(this CombinedResult<T1, KeyGroupFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyGroupFactory, T3, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3>(this CombinedResult<T1, T2, KeyGroupFactory, T3> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyGroupFactory, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, KeyGroupFactory> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KeyGroupFactory, T1, T2, T3, T4, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3, T4>(this CombinedResult<KeyGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyGroupFactory, T2, T3, T4, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3, T4>(this CombinedResult<T1, KeyGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyGroupFactory, T3, T4, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, KeyGroupFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyGroupFactory, T4, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KeyGroupFactory, T4> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KeyGroupFactory, InnerKeyGroupKeyGroupConfigFactory> WithKeyGroupConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KeyGroupFactory> combinedResult, Action<Humidifier.CloudFront.KeyGroupTypes.KeyGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyGroupConfig(combinedResult.T5, subFactoryAction));
}

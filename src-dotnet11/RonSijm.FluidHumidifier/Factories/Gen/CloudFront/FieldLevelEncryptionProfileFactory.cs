// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class FieldLevelEncryptionProfileFactory(string resourceName = null, Action<Humidifier.CloudFront.FieldLevelEncryptionProfile> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.FieldLevelEncryptionProfile>(resourceName)
{

    internal InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory FieldLevelEncryptionProfileConfigFactory { get; set; }

    protected override Humidifier.CloudFront.FieldLevelEncryptionProfile Create()
    {
        var fieldLevelEncryptionProfileResult = CreateFieldLevelEncryptionProfile();
        factoryAction?.Invoke(fieldLevelEncryptionProfileResult);

        return fieldLevelEncryptionProfileResult;
    }

    private Humidifier.CloudFront.FieldLevelEncryptionProfile CreateFieldLevelEncryptionProfile()
    {
        var fieldLevelEncryptionProfileResult = new Humidifier.CloudFront.FieldLevelEncryptionProfile
        {
            GivenName = InputResourceName,
        };

        return fieldLevelEncryptionProfileResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.FieldLevelEncryptionProfile result)
    {
        base.CreateChildren(result);

        result.FieldLevelEncryptionProfileConfig ??= FieldLevelEncryptionProfileConfigFactory?.Build();
    }

} // End Of Class

public static class FieldLevelEncryptionProfileFactoryExtensions
{
    public static CombinedResult<FieldLevelEncryptionProfileFactory, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig(this FieldLevelEncryptionProfileFactory parentFactory, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null)
    {
        parentFactory.FieldLevelEncryptionProfileConfigFactory = new InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldLevelEncryptionProfileConfigFactory);
    }

    public static CombinedResult<FieldLevelEncryptionProfileFactory, T1, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1>(this CombinedResult<FieldLevelEncryptionProfileFactory, T1> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldLevelEncryptionProfileFactory, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1>(this CombinedResult<T1, FieldLevelEncryptionProfileFactory> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2>(this CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2>(this CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2>(this CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2, T3, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3>(this CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2, T3, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3>(this CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory, T3, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3>(this CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory, T3> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FieldLevelEncryptionProfileFactory, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FieldLevelEncryptionProfileFactory> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2, T3, T4, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3, T4>(this CombinedResult<FieldLevelEncryptionProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2, T3, T4, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, FieldLevelEncryptionProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory, T3, T4, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FieldLevelEncryptionProfileFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FieldLevelEncryptionProfileFactory, T4, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FieldLevelEncryptionProfileFactory, T4> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FieldLevelEncryptionProfileFactory, InnerFieldLevelEncryptionProfileFieldLevelEncryptionProfileConfigFactory> WithFieldLevelEncryptionProfileConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FieldLevelEncryptionProfileFactory> combinedResult, Action<Humidifier.CloudFront.FieldLevelEncryptionProfileTypes.FieldLevelEncryptionProfileConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldLevelEncryptionProfileConfig(combinedResult.T5, subFactoryAction).T2);
}

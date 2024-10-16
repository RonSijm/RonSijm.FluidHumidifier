// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class PublicKeyFactory(string resourceName = null, Action<Humidifier.CloudFront.PublicKey> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.PublicKey>(resourceName)
{

    internal InnerPublicKeyPublicKeyConfigFactory PublicKeyConfigFactory { get; set; }

    protected override Humidifier.CloudFront.PublicKey Create()
    {
        var publicKeyResult = CreatePublicKey();
        factoryAction?.Invoke(publicKeyResult);

        return publicKeyResult;
    }

    private Humidifier.CloudFront.PublicKey CreatePublicKey()
    {
        var publicKeyResult = new Humidifier.CloudFront.PublicKey
        {
            GivenName = InputResourceName,
        };

        return publicKeyResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.PublicKey result)
    {
        base.CreateChildren(result);

        result.PublicKeyConfig ??= PublicKeyConfigFactory?.Build();
    }

} // End Of Class

public static class PublicKeyFactoryExtensions
{
    public static CombinedResult<PublicKeyFactory, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig(this PublicKeyFactory parentFactory, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null)
    {
        parentFactory.PublicKeyConfigFactory = new InnerPublicKeyPublicKeyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicKeyConfigFactory);
    }

    public static CombinedResult<PublicKeyFactory, T1, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1>(this CombinedResult<PublicKeyFactory, T1> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicKeyFactory, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1>(this CombinedResult<T1, PublicKeyFactory> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PublicKeyFactory, T1, T2, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2>(this CombinedResult<PublicKeyFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicKeyFactory, T2, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2>(this CombinedResult<T1, PublicKeyFactory, T2> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicKeyFactory, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2>(this CombinedResult<T1, T2, PublicKeyFactory> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PublicKeyFactory, T1, T2, T3, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3>(this CombinedResult<PublicKeyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicKeyFactory, T2, T3, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3>(this CombinedResult<T1, PublicKeyFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicKeyFactory, T3, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3>(this CombinedResult<T1, T2, PublicKeyFactory, T3> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicKeyFactory, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublicKeyFactory> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PublicKeyFactory, T1, T2, T3, T4, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3, T4>(this CombinedResult<PublicKeyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicKeyFactory, T2, T3, T4, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3, T4>(this CombinedResult<T1, PublicKeyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicKeyFactory, T3, T4, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublicKeyFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicKeyFactory, T4, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublicKeyFactory, T4> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PublicKeyFactory, InnerPublicKeyPublicKeyConfigFactory> WithPublicKeyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublicKeyFactory> combinedResult, Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicKeyConfig(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointEncryptionFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption>
{

    internal InnerOriginEndpointSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    internal InnerOriginEndpointEncryptionMethodFactory EncryptionMethodFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption();

        return encryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
        result.EncryptionMethod ??= EncryptionMethodFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointEncryptionFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerOriginEndpointEncryptionFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerOriginEndpointSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerOriginEndpointEncryptionFactory, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod(this InnerOriginEndpointEncryptionFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null)
    {
        parentFactory.EncryptionMethodFactory = new InnerOriginEndpointEncryptionMethodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionMethodFactory);
    }

    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, T4, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, T4, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, T4, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointEncryptionFactory, InnerOriginEndpointEncryptionMethodFactory> WithEncryptionMethod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointEncryptionFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionMethod(combinedResult.T5, subFactoryAction));
}

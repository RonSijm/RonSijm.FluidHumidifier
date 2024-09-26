// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointHlsEncryptionFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption>
{

    internal InnerOriginEndpointSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption Create()
    {
        var hlsEncryptionResult = CreateHlsEncryption();
        factoryAction?.Invoke(hlsEncryptionResult);

        return hlsEncryptionResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption CreateHlsEncryption()
    {
        var hlsEncryptionResult = new Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption();

        return hlsEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.HlsEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointHlsEncryptionFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointHlsEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerOriginEndpointHlsEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerOriginEndpointSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointHlsEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointHlsEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointHlsEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointHlsEncryptionFactory, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointHlsEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointHlsEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointCmafEncryptionFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption>
{

    internal InnerOriginEndpointSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption Create()
    {
        var cmafEncryptionResult = CreateCmafEncryption();
        factoryAction?.Invoke(cmafEncryptionResult);

        return cmafEncryptionResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption CreateCmafEncryption()
    {
        var cmafEncryptionResult = new Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption();

        return cmafEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointCmafEncryptionFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointCmafEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerOriginEndpointCmafEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerOriginEndpointSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointCmafEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointCmafEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointCmafEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafEncryptionFactory, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}

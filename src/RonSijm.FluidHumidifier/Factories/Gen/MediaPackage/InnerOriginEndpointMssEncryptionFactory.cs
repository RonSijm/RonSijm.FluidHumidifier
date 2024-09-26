// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointMssEncryptionFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption>
{

    internal InnerOriginEndpointSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption Create()
    {
        var mssEncryptionResult = CreateMssEncryption();
        factoryAction?.Invoke(mssEncryptionResult);

        return mssEncryptionResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption CreateMssEncryption()
    {
        var mssEncryptionResult = new Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption();

        return mssEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.MssEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointMssEncryptionFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointMssEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerOriginEndpointMssEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerOriginEndpointSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointMssEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointMssEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointMssEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssEncryptionFactory, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}

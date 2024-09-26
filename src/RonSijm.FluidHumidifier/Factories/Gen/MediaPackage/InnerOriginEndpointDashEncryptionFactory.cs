// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointDashEncryptionFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption>
{

    internal InnerOriginEndpointSpekeKeyProviderFactory SpekeKeyProviderFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption Create()
    {
        var dashEncryptionResult = CreateDashEncryption();
        factoryAction?.Invoke(dashEncryptionResult);

        return dashEncryptionResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption CreateDashEncryption()
    {
        var dashEncryptionResult = new Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption();

        return dashEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption result)
    {
        base.CreateChildren(result);

        result.SpekeKeyProvider ??= SpekeKeyProviderFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointDashEncryptionFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointDashEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider(this InnerOriginEndpointDashEncryptionFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null)
    {
        parentFactory.SpekeKeyProviderFactory = new InnerOriginEndpointSpekeKeyProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpekeKeyProviderFactory);
    }

    public static CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1>(this CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory, T3, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointDashEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointDashEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointDashEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashEncryptionFactory, T4, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashEncryptionFactory, InnerOriginEndpointSpekeKeyProviderFactory> WithSpekeKeyProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashEncryptionFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.SpekeKeyProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpekeKeyProvider(combinedResult.T5, subFactoryAction));
}

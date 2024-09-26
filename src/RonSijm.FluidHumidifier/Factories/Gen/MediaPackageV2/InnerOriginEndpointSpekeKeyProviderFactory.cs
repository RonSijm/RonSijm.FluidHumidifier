// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointSpekeKeyProviderFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider>
{

    internal InnerOriginEndpointEncryptionContractConfigurationFactory EncryptionContractConfigurationFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider Create()
    {
        var spekeKeyProviderResult = CreateSpekeKeyProvider();
        factoryAction?.Invoke(spekeKeyProviderResult);

        return spekeKeyProviderResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider CreateSpekeKeyProvider()
    {
        var spekeKeyProviderResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider();

        return spekeKeyProviderResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.SpekeKeyProvider result)
    {
        base.CreateChildren(result);

        result.EncryptionContractConfiguration ??= EncryptionContractConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointSpekeKeyProviderFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration(this InnerOriginEndpointSpekeKeyProviderFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionContractConfigurationFactory = new InnerOriginEndpointEncryptionContractConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionContractConfigurationFactory);
    }

    public static CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1>(this CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1>(this CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2, T3, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2, T3, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory, T3, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2, T3, T4, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointSpekeKeyProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2, T3, T4, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointSpekeKeyProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory, T3, T4, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointSpekeKeyProviderFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory, T4, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSpekeKeyProviderFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory, InnerOriginEndpointEncryptionContractConfigurationFactory> WithEncryptionContractConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSpekeKeyProviderFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionContractConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionContractConfiguration(combinedResult.T5, subFactoryAction));
}

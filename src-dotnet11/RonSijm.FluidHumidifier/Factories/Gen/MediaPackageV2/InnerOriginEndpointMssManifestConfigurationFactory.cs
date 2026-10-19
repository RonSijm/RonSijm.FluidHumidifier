// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointMssManifestConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration>
{

    internal InnerOriginEndpointMssFilterConfigurationFactory FilterConfigurationFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration Create()
    {
        var mssManifestConfigurationResult = CreateMssManifestConfiguration();
        factoryAction?.Invoke(mssManifestConfigurationResult);

        return mssManifestConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration CreateMssManifestConfiguration()
    {
        var mssManifestConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration();

        return mssManifestConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.MssManifestConfiguration result)
    {
        base.CreateChildren(result);

        result.FilterConfiguration ??= FilterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointMssManifestConfigurationFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration(this InnerOriginEndpointMssManifestConfigurationFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.FilterConfigurationFactory = new InnerOriginEndpointMssFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterConfigurationFactory);
    }

    public static CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2, T3, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2, T3, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory, T3, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssManifestConfigurationFactory, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssManifestConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2, T3, T4, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointMssManifestConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2, T3, T4, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointMssManifestConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory, T3, T4, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointMssManifestConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointMssManifestConfigurationFactory, T4, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointMssManifestConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssManifestConfigurationFactory, InnerOriginEndpointMssFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointMssManifestConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T5, subFactoryAction).T2);
}

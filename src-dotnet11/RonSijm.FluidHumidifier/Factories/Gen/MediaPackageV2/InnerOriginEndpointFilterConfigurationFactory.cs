// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointFilterConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration>
{

    internal InnerOriginEndpointMultiviewFilterConfigurationFactory MultiviewFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration Create()
    {
        var filterConfigurationResult = CreateFilterConfiguration();
        factoryAction?.Invoke(filterConfigurationResult);

        return filterConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration CreateFilterConfiguration()
    {
        var filterConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration();

        return filterConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration result)
    {
        base.CreateChildren(result);

        result.Multiview ??= MultiviewFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointFilterConfigurationFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointFilterConfigurationFactory, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview(this InnerOriginEndpointFilterConfigurationFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.MultiviewFactory = new InnerOriginEndpointMultiviewFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiviewFactory);
    }

    public static CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1>(this CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1>(this CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2>(this CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2>(this CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2, T3, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3>(this CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2, T3, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory, T3, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointFilterConfigurationFactory, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointFilterConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2, T3, T4, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointFilterConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2, T3, T4, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointFilterConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory, T3, T4, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointFilterConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointFilterConfigurationFactory, T4, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointFilterConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointFilterConfigurationFactory, InnerOriginEndpointMultiviewFilterConfigurationFactory> WithMultiview<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointFilterConfigurationFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiview(combinedResult.T5, subFactoryAction).T2);
}

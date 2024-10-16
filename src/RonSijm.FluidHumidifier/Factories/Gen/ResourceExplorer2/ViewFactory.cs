// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceExplorer2;

public class ViewFactory(string resourceName = null, Action<Humidifier.ResourceExplorer2.View> factoryAction = null) : ResourceFactory<Humidifier.ResourceExplorer2.View>(resourceName)
{

    internal List<InnerViewIncludedPropertyFactory> IncludedPropertiesFactories { get; set; } = [];

    internal InnerViewSearchFilterFactory FiltersFactory { get; set; }

    protected override Humidifier.ResourceExplorer2.View Create()
    {
        var viewResult = CreateView();
        factoryAction?.Invoke(viewResult);

        return viewResult;
    }

    private Humidifier.ResourceExplorer2.View CreateView()
    {
        var viewResult = new Humidifier.ResourceExplorer2.View
        {
            GivenName = InputResourceName,
        };

        return viewResult;
    }
    public override void CreateChildren(Humidifier.ResourceExplorer2.View result)
    {
        base.CreateChildren(result);

        result.IncludedProperties = IncludedPropertiesFactories.Any() ? IncludedPropertiesFactories.Select(x => x.Build()).ToList() : null;
        result.Filters ??= FiltersFactory?.Build();
    }

} // End Of Class

public static class ViewFactoryExtensions
{
    public static CombinedResult<ViewFactory, InnerViewIncludedPropertyFactory> WithIncludedProperties(this ViewFactory parentFactory, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null)
    {
        var factory = new InnerViewIncludedPropertyFactory(subFactoryAction);
        parentFactory.IncludedPropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ViewFactory, InnerViewSearchFilterFactory> WithFilters(this ViewFactory parentFactory, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null)
    {
        parentFactory.FiltersFactory = new InnerViewSearchFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FiltersFactory);
    }

    public static CombinedResult<ViewFactory, T1, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1>(this CombinedResult<ViewFactory, T1> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludedProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1>(this CombinedResult<T1, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludedProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2>(this CombinedResult<ViewFactory, T1, T2> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2>(this CombinedResult<T1, ViewFactory, T2> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2>(this CombinedResult<T1, T2, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, T3, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3>(this CombinedResult<ViewFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, T3, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3>(this CombinedResult<T1, ViewFactory, T2, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, T3, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3>(this CombinedResult<T1, T2, ViewFactory, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ViewFactory, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, T3, T4, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3, T4>(this CombinedResult<ViewFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, T3, T4, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3, T4>(this CombinedResult<T1, ViewFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, T3, T4, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ViewFactory, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ViewFactory, T4, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ViewFactory, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ViewFactory, InnerViewIncludedPropertyFactory> WithIncludedProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.IncludedProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludedProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, InnerViewSearchFilterFactory> WithFilters<T1>(this CombinedResult<ViewFactory, T1> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, InnerViewSearchFilterFactory> WithFilters<T1>(this CombinedResult<T1, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, InnerViewSearchFilterFactory> WithFilters<T1, T2>(this CombinedResult<ViewFactory, T1, T2> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, InnerViewSearchFilterFactory> WithFilters<T1, T2>(this CombinedResult<T1, ViewFactory, T2> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, InnerViewSearchFilterFactory> WithFilters<T1, T2>(this CombinedResult<T1, T2, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, T3, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3>(this CombinedResult<ViewFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, T3, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, ViewFactory, T2, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, T3, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, ViewFactory, T3> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ViewFactory, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ViewFactory, T1, T2, T3, T4, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<ViewFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ViewFactory, T2, T3, T4, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, ViewFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ViewFactory, T3, T4, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ViewFactory, T3, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ViewFactory, T4, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ViewFactory, T4> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ViewFactory, InnerViewSearchFilterFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ViewFactory> combinedResult, Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T5, subFactoryAction));
}

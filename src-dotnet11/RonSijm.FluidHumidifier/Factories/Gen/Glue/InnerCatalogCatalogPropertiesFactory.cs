// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogCatalogPropertiesFactory(Action<Humidifier.Glue.CatalogTypes.CatalogProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.CatalogProperties>
{

    internal InnerCatalogDataLakeAccessPropertiesFactory DataLakeAccessPropertiesFactory { get; set; }

    protected override Humidifier.Glue.CatalogTypes.CatalogProperties Create()
    {
        var catalogPropertiesResult = CreateCatalogProperties();
        factoryAction?.Invoke(catalogPropertiesResult);

        return catalogPropertiesResult;
    }

    private Humidifier.Glue.CatalogTypes.CatalogProperties CreateCatalogProperties()
    {
        var catalogPropertiesResult = new Humidifier.Glue.CatalogTypes.CatalogProperties();

        return catalogPropertiesResult;
    }
    public override void CreateChildren(Humidifier.Glue.CatalogTypes.CatalogProperties result)
    {
        base.CreateChildren(result);

        result.DataLakeAccessProperties ??= DataLakeAccessPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerCatalogCatalogPropertiesFactoryExtensions
{
    public static CombinedResult<InnerCatalogCatalogPropertiesFactory, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties(this InnerCatalogCatalogPropertiesFactory parentFactory, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null)
    {
        parentFactory.DataLakeAccessPropertiesFactory = new InnerCatalogDataLakeAccessPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataLakeAccessPropertiesFactory);
    }

    public static CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1>(this CombinedResult<InnerCatalogCatalogPropertiesFactory, T1> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1>(this CombinedResult<T1, InnerCatalogCatalogPropertiesFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2>(this CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2>(this CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2>(this CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2, T3, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3>(this CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2, T3, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3>(this CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory, T3, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory, T3> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCatalogCatalogPropertiesFactory, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCatalogCatalogPropertiesFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2, T3, T4, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3, T4>(this CombinedResult<InnerCatalogCatalogPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2, T3, T4, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerCatalogCatalogPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory, T3, T4, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCatalogCatalogPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCatalogCatalogPropertiesFactory, T4, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCatalogCatalogPropertiesFactory, T4> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCatalogCatalogPropertiesFactory, InnerCatalogDataLakeAccessPropertiesFactory> WithDataLakeAccessProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCatalogCatalogPropertiesFactory> combinedResult, Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataLakeAccessProperties(combinedResult.T5, subFactoryAction).T2);
}

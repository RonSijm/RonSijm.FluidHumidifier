// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class ExportFactory(string resourceName = null, Action<Humidifier.BCMDataExports.Export> factoryAction = null) : ResourceFactory<Humidifier.BCMDataExports.Export>(resourceName)
{

    internal List<InnerExportResourceTagFactory> TagsFactories { get; set; } = [];

    internal InnerExportExportFactory Export_Factory { get; set; }

    protected override Humidifier.BCMDataExports.Export Create()
    {
        var exportResult = CreateExport();
        factoryAction?.Invoke(exportResult);

        return exportResult;
    }

    private Humidifier.BCMDataExports.Export CreateExport()
    {
        var exportResult = new Humidifier.BCMDataExports.Export
        {
            GivenName = InputResourceName,
        };

        return exportResult;
    }
    public override void CreateChildren(Humidifier.BCMDataExports.Export result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Export_ ??= Export_Factory?.Build();
    }

} // End Of Class

public static class ExportFactoryExtensions
{
    public static CombinedResult<ExportFactory, InnerExportResourceTagFactory> WithTags(this ExportFactory parentFactory, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerExportResourceTagFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ExportFactory, InnerExportExportFactory> WithExport_(this ExportFactory parentFactory, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null)
    {
        parentFactory.Export_Factory = new InnerExportExportFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Export_Factory);
    }

    public static CombinedResult<ExportFactory, T1, InnerExportResourceTagFactory> WithTags<T1>(this CombinedResult<ExportFactory, T1> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, InnerExportResourceTagFactory> WithTags<T1>(this CombinedResult<T1, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, InnerExportResourceTagFactory> WithTags<T1, T2>(this CombinedResult<ExportFactory, T1, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, InnerExportResourceTagFactory> WithTags<T1, T2>(this CombinedResult<T1, ExportFactory, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, InnerExportResourceTagFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, T3, InnerExportResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<ExportFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, T3, InnerExportResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ExportFactory, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, T3, InnerExportResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ExportFactory, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExportFactory, InnerExportResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, T3, T4, InnerExportResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ExportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, T3, T4, InnerExportResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ExportFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, T3, T4, InnerExportResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExportFactory, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExportFactory, T4, InnerExportResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExportFactory, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExportFactory, InnerExportResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, InnerExportExportFactory> WithExport_<T1>(this CombinedResult<ExportFactory, T1> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, WithExport_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, InnerExportExportFactory> WithExport_<T1>(this CombinedResult<T1, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, WithExport_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, InnerExportExportFactory> WithExport_<T1, T2>(this CombinedResult<ExportFactory, T1, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, InnerExportExportFactory> WithExport_<T1, T2>(this CombinedResult<T1, ExportFactory, T2> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, InnerExportExportFactory> WithExport_<T1, T2>(this CombinedResult<T1, T2, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, T3, InnerExportExportFactory> WithExport_<T1, T2, T3>(this CombinedResult<ExportFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, T3, InnerExportExportFactory> WithExport_<T1, T2, T3>(this CombinedResult<T1, ExportFactory, T2, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, T3, InnerExportExportFactory> WithExport_<T1, T2, T3>(this CombinedResult<T1, T2, ExportFactory, T3> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExportFactory, InnerExportExportFactory> WithExport_<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExportFactory, T1, T2, T3, T4, InnerExportExportFactory> WithExport_<T1, T2, T3, T4>(this CombinedResult<ExportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExportFactory, T2, T3, T4, InnerExportExportFactory> WithExport_<T1, T2, T3, T4>(this CombinedResult<T1, ExportFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExportFactory, T3, T4, InnerExportExportFactory> WithExport_<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExportFactory, T3, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExportFactory, T4, InnerExportExportFactory> WithExport_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExportFactory, T4> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExportFactory, InnerExportExportFactory> WithExport_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExportFactory> combinedResult, Action<Humidifier.BCMDataExports.ExportTypes.Export> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExport_(combinedResult.T5, subFactoryAction));
}

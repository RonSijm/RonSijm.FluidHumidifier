// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class ReportGroupFactory(string resourceName = null, Action<Humidifier.CodeBuild.ReportGroup> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.ReportGroup>(resourceName)
{

    internal InnerReportGroupReportExportConfigFactory ExportConfigFactory { get; set; }

    protected override Humidifier.CodeBuild.ReportGroup Create()
    {
        var reportGroupResult = CreateReportGroup();
        factoryAction?.Invoke(reportGroupResult);

        return reportGroupResult;
    }

    private Humidifier.CodeBuild.ReportGroup CreateReportGroup()
    {
        var reportGroupResult = new Humidifier.CodeBuild.ReportGroup
        {
            GivenName = InputResourceName,
        };

        return reportGroupResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ReportGroup result)
    {
        base.CreateChildren(result);

        result.ExportConfig ??= ExportConfigFactory?.Build();
    }

} // End Of Class

public static class ReportGroupFactoryExtensions
{
    public static CombinedResult<ReportGroupFactory, InnerReportGroupReportExportConfigFactory> WithExportConfig(this ReportGroupFactory parentFactory, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null)
    {
        parentFactory.ExportConfigFactory = new InnerReportGroupReportExportConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportConfigFactory);
    }

    public static CombinedResult<ReportGroupFactory, T1, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1>(this CombinedResult<ReportGroupFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportGroupFactory, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1>(this CombinedResult<T1, ReportGroupFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReportGroupFactory, T1, T2, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<ReportGroupFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportGroupFactory, T2, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<T1, ReportGroupFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportGroupFactory, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2>(this CombinedResult<T1, T2, ReportGroupFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReportGroupFactory, T1, T2, T3, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<ReportGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportGroupFactory, T2, T3, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, ReportGroupFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportGroupFactory, T3, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, T2, ReportGroupFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportGroupFactory, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReportGroupFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReportGroupFactory, T1, T2, T3, T4, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<ReportGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReportGroupFactory, T2, T3, T4, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, ReportGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReportGroupFactory, T3, T4, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReportGroupFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReportGroupFactory, T4, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReportGroupFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReportGroupFactory, InnerReportGroupReportExportConfigFactory> WithExportConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReportGroupFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportConfig(combinedResult.T5, subFactoryAction));
}

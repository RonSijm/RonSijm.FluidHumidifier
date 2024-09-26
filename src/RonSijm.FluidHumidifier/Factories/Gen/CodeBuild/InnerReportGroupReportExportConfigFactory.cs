// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerReportGroupReportExportConfigFactory(Action<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig>
{

    internal InnerReportGroupS3ReportExportConfigFactory S3DestinationFactory { get; set; }

    protected override Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig Create()
    {
        var reportExportConfigResult = CreateReportExportConfig();
        factoryAction?.Invoke(reportExportConfigResult);

        return reportExportConfigResult;
    }

    private Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig CreateReportExportConfig()
    {
        var reportExportConfigResult = new Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig();

        return reportExportConfigResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerReportGroupReportExportConfigFactoryExtensions
{
    public static CombinedResult<InnerReportGroupReportExportConfigFactory, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination(this InnerReportGroupReportExportConfigFactory parentFactory, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerReportGroupS3ReportExportConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<InnerReportGroupReportExportConfigFactory, T1, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1>(this CombinedResult<InnerReportGroupReportExportConfigFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReportGroupReportExportConfigFactory, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1>(this CombinedResult<T1, InnerReportGroupReportExportConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2, T3, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2, T3, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory, T3, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReportGroupReportExportConfigFactory, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReportGroupReportExportConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2, T3, T4, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<InnerReportGroupReportExportConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2, T3, T4, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, InnerReportGroupReportExportConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory, T3, T4, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReportGroupReportExportConfigFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReportGroupReportExportConfigFactory, T4, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReportGroupReportExportConfigFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReportGroupReportExportConfigFactory, InnerReportGroupS3ReportExportConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReportGroupReportExportConfigFactory> combinedResult, Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction));
}

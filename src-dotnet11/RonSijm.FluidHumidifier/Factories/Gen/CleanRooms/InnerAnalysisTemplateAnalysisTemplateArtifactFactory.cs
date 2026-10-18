// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisTemplateArtifactFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact>
{

    internal InnerAnalysisTemplateS3LocationFactory LocationFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact Create()
    {
        var analysisTemplateArtifactResult = CreateAnalysisTemplateArtifact();
        factoryAction?.Invoke(analysisTemplateArtifactResult);

        return analysisTemplateArtifactResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact CreateAnalysisTemplateArtifact()
    {
        var analysisTemplateArtifactResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact();

        return analysisTemplateArtifactResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisTemplateArtifactFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, InnerAnalysisTemplateS3LocationFactory> WithLocation(this InnerAnalysisTemplateAnalysisTemplateArtifactFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerAnalysisTemplateS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2, T3, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2, T3, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T3, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2, T3, T4, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2, T3, T4, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T3, T4, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T4, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory, InnerAnalysisTemplateS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction).T2);
}

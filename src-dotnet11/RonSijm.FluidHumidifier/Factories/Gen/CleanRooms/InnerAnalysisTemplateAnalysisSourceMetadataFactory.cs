// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisSourceMetadataFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata>
{

    internal InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory ArtifactsFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata Create()
    {
        var analysisSourceMetadataResult = CreateAnalysisSourceMetadata();
        factoryAction?.Invoke(analysisSourceMetadataResult);

        return analysisSourceMetadataResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata CreateAnalysisSourceMetadata()
    {
        var analysisSourceMetadataResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata();

        return analysisSourceMetadataResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata result)
    {
        base.CreateChildren(result);

        result.Artifacts ??= ArtifactsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisSourceMetadataFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts(this InnerAnalysisTemplateAnalysisSourceMetadataFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null)
    {
        parentFactory.ArtifactsFactory = new InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArtifactsFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceMetadataFactory, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceMetadataFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceMetadataFactory, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T5, subFactoryAction).T2);
}

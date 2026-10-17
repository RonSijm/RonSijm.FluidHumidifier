// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata>
{

    internal InnerAnalysisTemplateHashFactory EntryPointHashFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata Create()
    {
        var analysisTemplateArtifactMetadataResult = CreateAnalysisTemplateArtifactMetadata();
        factoryAction?.Invoke(analysisTemplateArtifactMetadataResult);

        return analysisTemplateArtifactMetadataResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata CreateAnalysisTemplateArtifactMetadata()
    {
        var analysisTemplateArtifactMetadataResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata();

        return analysisTemplateArtifactMetadataResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata result)
    {
        base.CreateChildren(result);

        result.EntryPointHash ??= EntryPointHashFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, InnerAnalysisTemplateHashFactory> WithEntryPointHash(this InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null)
    {
        parentFactory.EntryPointHashFactory = new InnerAnalysisTemplateHashFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EntryPointHashFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPointHash(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPointHash(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2, T3, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2, T3, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T3, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2, T3, T4, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2, T3, T4, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T3, T4, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T4, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory, InnerAnalysisTemplateHashFactory> WithEntryPointHash<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactMetadataFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPointHash(combinedResult.T5, subFactoryAction).T2);
}

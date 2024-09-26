// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensStorageLensGroupLevelFactory(Action<Humidifier.S3.StorageLensTypes.StorageLensGroupLevel> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.StorageLensGroupLevel>
{

    internal InnerStorageLensStorageLensGroupSelectionCriteriaFactory StorageLensGroupSelectionCriteriaFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.StorageLensGroupLevel Create()
    {
        var storageLensGroupLevelResult = CreateStorageLensGroupLevel();
        factoryAction?.Invoke(storageLensGroupLevelResult);

        return storageLensGroupLevelResult;
    }

    private Humidifier.S3.StorageLensTypes.StorageLensGroupLevel CreateStorageLensGroupLevel()
    {
        var storageLensGroupLevelResult = new Humidifier.S3.StorageLensTypes.StorageLensGroupLevel();

        return storageLensGroupLevelResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.StorageLensGroupLevel result)
    {
        base.CreateChildren(result);

        result.StorageLensGroupSelectionCriteria ??= StorageLensGroupSelectionCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensStorageLensGroupLevelFactoryExtensions
{
    public static CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria(this InnerStorageLensStorageLensGroupLevelFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null)
    {
        parentFactory.StorageLensGroupSelectionCriteriaFactory = new InnerStorageLensStorageLensGroupSelectionCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageLensGroupSelectionCriteriaFactory);
    }

    public static CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1>(this CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1>(this CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2>(this CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2>(this CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2, T3, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3>(this CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2, T3, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory, T3, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensStorageLensGroupLevelFactory, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensStorageLensGroupLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2, T3, T4, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensStorageLensGroupLevelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2, T3, T4, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensStorageLensGroupLevelFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory, T3, T4, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensStorageLensGroupLevelFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensStorageLensGroupLevelFactory, T4, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensStorageLensGroupLevelFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensStorageLensGroupLevelFactory, InnerStorageLensStorageLensGroupSelectionCriteriaFactory> WithStorageLensGroupSelectionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensStorageLensGroupLevelFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageLensGroupSelectionCriteria(combinedResult.T5, subFactoryAction));
}

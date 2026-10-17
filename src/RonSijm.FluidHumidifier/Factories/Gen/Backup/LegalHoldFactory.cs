// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class LegalHoldFactory(string resourceName = null, Action<Humidifier.Backup.LegalHold> factoryAction = null) : ResourceFactory<Humidifier.Backup.LegalHold>(resourceName)
{

    internal List<InnerLegalHoldTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerLegalHoldRecoveryPointSelectionFactory RecoveryPointSelectionFactory { get; set; }

    protected override Humidifier.Backup.LegalHold Create()
    {
        var legalHoldResult = CreateLegalHold();
        factoryAction?.Invoke(legalHoldResult);

        return legalHoldResult;
    }

    private Humidifier.Backup.LegalHold CreateLegalHold()
    {
        var legalHoldResult = new Humidifier.Backup.LegalHold
        {
            GivenName = InputResourceName,
        };

        return legalHoldResult;
    }
    public override void CreateChildren(Humidifier.Backup.LegalHold result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.RecoveryPointSelection ??= RecoveryPointSelectionFactory?.Build();
    }

} // End Of Class

public static class LegalHoldFactoryExtensions
{
    public static CombinedResult<LegalHoldFactory, InnerLegalHoldTagsItemsFactory> WithTags(this LegalHoldFactory parentFactory, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerLegalHoldTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LegalHoldFactory, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection(this LegalHoldFactory parentFactory, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null)
    {
        parentFactory.RecoveryPointSelectionFactory = new InnerLegalHoldRecoveryPointSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecoveryPointSelectionFactory);
    }

    public static CombinedResult<LegalHoldFactory, T1, InnerLegalHoldTagsItemsFactory> WithTags<T1>(this CombinedResult<LegalHoldFactory, T1> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, InnerLegalHoldTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<LegalHoldFactory, T1, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, LegalHoldFactory, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, T3, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<LegalHoldFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, T3, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, LegalHoldFactory, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, T3, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, LegalHoldFactory, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LegalHoldFactory, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, T3, T4, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<LegalHoldFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, T3, T4, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, LegalHoldFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, T3, T4, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, LegalHoldFactory, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LegalHoldFactory, T4, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LegalHoldFactory, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LegalHoldFactory, InnerLegalHoldTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1>(this CombinedResult<LegalHoldFactory, T1> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1>(this CombinedResult<T1, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<LegalHoldFactory, T1, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<T1, LegalHoldFactory, T2> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2>(this CombinedResult<T1, T2, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<LegalHoldFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, T3, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, LegalHoldFactory, T2, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, T3, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, T2, LegalHoldFactory, T3> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LegalHoldFactory, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LegalHoldFactory, T1, T2, T3, T4, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<LegalHoldFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LegalHoldFactory, T2, T3, T4, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, LegalHoldFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LegalHoldFactory, T3, T4, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, LegalHoldFactory, T3, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LegalHoldFactory, T4, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LegalHoldFactory, T4> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LegalHoldFactory, InnerLegalHoldRecoveryPointSelectionFactory> WithRecoveryPointSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LegalHoldFactory> combinedResult, Action<Humidifier.Backup.LegalHoldTypes.RecoveryPointSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecoveryPointSelection(combinedResult.T5, subFactoryAction).T2);
}

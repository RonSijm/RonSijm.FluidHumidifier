// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class AssistantAssociationFactory(string resourceName = null, Action<Humidifier.Wisdom.AssistantAssociation> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.AssistantAssociation>(resourceName)
{

    internal InnerAssistantAssociationAssociationDataFactory AssociationFactory { get; set; }

    protected override Humidifier.Wisdom.AssistantAssociation Create()
    {
        var assistantAssociationResult = CreateAssistantAssociation();
        factoryAction?.Invoke(assistantAssociationResult);

        return assistantAssociationResult;
    }

    private Humidifier.Wisdom.AssistantAssociation CreateAssistantAssociation()
    {
        var assistantAssociationResult = new Humidifier.Wisdom.AssistantAssociation
        {
            GivenName = InputResourceName,
        };

        return assistantAssociationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.AssistantAssociation result)
    {
        base.CreateChildren(result);

        result.Association ??= AssociationFactory?.Build();
    }

} // End Of Class

public static class AssistantAssociationFactoryExtensions
{
    public static CombinedResult<AssistantAssociationFactory, InnerAssistantAssociationAssociationDataFactory> WithAssociation(this AssistantAssociationFactory parentFactory, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null)
    {
        parentFactory.AssociationFactory = new InnerAssistantAssociationAssociationDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AssociationFactory);
    }

    public static CombinedResult<AssistantAssociationFactory, T1, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1>(this CombinedResult<AssistantAssociationFactory, T1> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantAssociationFactory, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1>(this CombinedResult<T1, AssistantAssociationFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssistantAssociationFactory, T1, T2, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2>(this CombinedResult<AssistantAssociationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantAssociationFactory, T2, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2>(this CombinedResult<T1, AssistantAssociationFactory, T2> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantAssociationFactory, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2>(this CombinedResult<T1, T2, AssistantAssociationFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssistantAssociationFactory, T1, T2, T3, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3>(this CombinedResult<AssistantAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantAssociationFactory, T2, T3, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, AssistantAssociationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantAssociationFactory, T3, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, T2, AssistantAssociationFactory, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssistantAssociationFactory, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssistantAssociationFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssistantAssociationFactory, T1, T2, T3, T4, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<AssistantAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssistantAssociationFactory, T2, T3, T4, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, AssistantAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssistantAssociationFactory, T3, T4, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssistantAssociationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssistantAssociationFactory, T4, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssistantAssociationFactory, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssistantAssociationFactory, InnerAssistantAssociationAssociationDataFactory> WithAssociation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssistantAssociationFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociation(combinedResult.T5, subFactoryAction));
}

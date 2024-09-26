// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class CalculatedAttributeDefinitionFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinition> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinition>(resourceName)
{

    internal InnerCalculatedAttributeDefinitionAttributeDetailsFactory AttributeDetailsFactory { get; set; }

    internal InnerCalculatedAttributeDefinitionConditionsFactory ConditionsFactory { get; set; }

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinition Create()
    {
        var calculatedAttributeDefinitionResult = CreateCalculatedAttributeDefinition();
        factoryAction?.Invoke(calculatedAttributeDefinitionResult);

        return calculatedAttributeDefinitionResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinition CreateCalculatedAttributeDefinition()
    {
        var calculatedAttributeDefinitionResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinition
        {
            GivenName = InputResourceName,
        };

        return calculatedAttributeDefinitionResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.CalculatedAttributeDefinition result)
    {
        base.CreateChildren(result);

        result.AttributeDetails ??= AttributeDetailsFactory?.Build();
        result.Conditions ??= ConditionsFactory?.Build();
    }

} // End Of Class

public static class CalculatedAttributeDefinitionFactoryExtensions
{
    public static CombinedResult<CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails(this CalculatedAttributeDefinitionFactory parentFactory, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null)
    {
        parentFactory.AttributeDetailsFactory = new InnerCalculatedAttributeDefinitionAttributeDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AttributeDetailsFactory);
    }

    public static CombinedResult<CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions(this CalculatedAttributeDefinitionFactory parentFactory, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null)
    {
        parentFactory.ConditionsFactory = new InnerCalculatedAttributeDefinitionConditionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionsFactory);
    }

    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, T4, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3, T4>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, T4, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3, T4>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, T4, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, T4, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionAttributeDetailsFactory> WithAttributeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, T4, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<CalculatedAttributeDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, T4, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, CalculatedAttributeDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, T4, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, CalculatedAttributeDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, T4, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CalculatedAttributeDefinitionFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CalculatedAttributeDefinitionFactory, InnerCalculatedAttributeDefinitionConditionsFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CalculatedAttributeDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Conditions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction));
}

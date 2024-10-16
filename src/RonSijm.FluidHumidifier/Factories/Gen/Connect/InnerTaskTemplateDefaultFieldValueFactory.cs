// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTaskTemplateDefaultFieldValueFactory(Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue>
{

    internal InnerTaskTemplateFieldIdentifierFactory IdFactory { get; set; }

    protected override Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue Create()
    {
        var defaultFieldValueResult = CreateDefaultFieldValue();
        factoryAction?.Invoke(defaultFieldValueResult);

        return defaultFieldValueResult;
    }

    private Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue CreateDefaultFieldValue()
    {
        var defaultFieldValueResult = new Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue();

        return defaultFieldValueResult;
    }
    public override void CreateChildren(Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue result)
    {
        base.CreateChildren(result);

        result.Id ??= IdFactory?.Build();
    }

} // End Of Class

public static class InnerTaskTemplateDefaultFieldValueFactoryExtensions
{
    public static CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, InnerTaskTemplateFieldIdentifierFactory> WithId(this InnerTaskTemplateDefaultFieldValueFactory parentFactory, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null)
    {
        parentFactory.IdFactory = new InnerTaskTemplateFieldIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdFactory);
    }

    public static CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, InnerTaskTemplateFieldIdentifierFactory> WithId<T1>(this CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1>(this CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTemplateDefaultFieldValueFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskTemplateDefaultFieldValueFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<InnerTaskTemplateDefaultFieldValueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskTemplateDefaultFieldValueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskTemplateDefaultFieldValueFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTemplateDefaultFieldValueFactory, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskTemplateDefaultFieldValueFactory, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskTemplateDefaultFieldValueFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskTemplateDefaultFieldValueFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T5, subFactoryAction));
}

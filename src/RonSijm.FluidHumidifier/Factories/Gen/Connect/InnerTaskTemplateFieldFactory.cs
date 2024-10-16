// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTaskTemplateFieldFactory(Action<Humidifier.Connect.TaskTemplateTypes.Field> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TaskTemplateTypes.Field>
{

    internal InnerTaskTemplateFieldIdentifierFactory IdFactory { get; set; }

    protected override Humidifier.Connect.TaskTemplateTypes.Field Create()
    {
        var fieldResult = CreateField();
        factoryAction?.Invoke(fieldResult);

        return fieldResult;
    }

    private Humidifier.Connect.TaskTemplateTypes.Field CreateField()
    {
        var fieldResult = new Humidifier.Connect.TaskTemplateTypes.Field();

        return fieldResult;
    }
    public override void CreateChildren(Humidifier.Connect.TaskTemplateTypes.Field result)
    {
        base.CreateChildren(result);

        result.Id ??= IdFactory?.Build();
    }

} // End Of Class

public static class InnerTaskTemplateFieldFactoryExtensions
{
    public static CombinedResult<InnerTaskTemplateFieldFactory, InnerTaskTemplateFieldIdentifierFactory> WithId(this InnerTaskTemplateFieldFactory parentFactory, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null)
    {
        parentFactory.IdFactory = new InnerTaskTemplateFieldIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdFactory);
    }

    public static CombinedResult<InnerTaskTemplateFieldFactory, T1, InnerTaskTemplateFieldIdentifierFactory> WithId<T1>(this CombinedResult<InnerTaskTemplateFieldFactory, T1> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateFieldFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1>(this CombinedResult<T1, InnerTaskTemplateFieldFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateFieldFactory, T1, T2, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<InnerTaskTemplateFieldFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateFieldFactory, T2, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<T1, InnerTaskTemplateFieldFactory, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateFieldFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2>(this CombinedResult<T1, T2, InnerTaskTemplateFieldFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateFieldFactory, T1, T2, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<InnerTaskTemplateFieldFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateFieldFactory, T2, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, InnerTaskTemplateFieldFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateFieldFactory, T3, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskTemplateFieldFactory, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTemplateFieldFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskTemplateFieldFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskTemplateFieldFactory, T1, T2, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<InnerTaskTemplateFieldFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTemplateFieldFactory, T2, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskTemplateFieldFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTemplateFieldFactory, T3, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskTemplateFieldFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTemplateFieldFactory, T4, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskTemplateFieldFactory, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskTemplateFieldFactory, InnerTaskTemplateFieldIdentifierFactory> WithId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskTemplateFieldFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithId(combinedResult.T5, subFactoryAction));
}

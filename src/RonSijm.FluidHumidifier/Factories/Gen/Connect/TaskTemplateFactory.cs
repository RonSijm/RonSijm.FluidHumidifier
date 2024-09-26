// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class TaskTemplateFactory(string resourceName = null, Action<Humidifier.Connect.TaskTemplate> factoryAction = null) : ResourceFactory<Humidifier.Connect.TaskTemplate>(resourceName)
{

    internal List<InnerTaskTemplateDefaultFieldValueFactory> DefaultsFactories { get; set; } = [];

    internal List<InnerTaskTemplateFieldFactory> FieldsFactories { get; set; } = [];

    internal InnerTaskTemplateConstraintsFactory ConstraintsFactory { get; set; }

    protected override Humidifier.Connect.TaskTemplate Create()
    {
        var taskTemplateResult = CreateTaskTemplate();
        factoryAction?.Invoke(taskTemplateResult);

        return taskTemplateResult;
    }

    private Humidifier.Connect.TaskTemplate CreateTaskTemplate()
    {
        var taskTemplateResult = new Humidifier.Connect.TaskTemplate
        {
            GivenName = InputResourceName,
        };

        return taskTemplateResult;
    }
    public override void CreateChildren(Humidifier.Connect.TaskTemplate result)
    {
        base.CreateChildren(result);

        result.Defaults = DefaultsFactories.Any() ? DefaultsFactories.Select(x => x.Build()).ToList() : null;
        result.Fields = FieldsFactories.Any() ? FieldsFactories.Select(x => x.Build()).ToList() : null;
        result.Constraints ??= ConstraintsFactory?.Build();
    }

} // End Of Class

public static class TaskTemplateFactoryExtensions
{
    public static CombinedResult<TaskTemplateFactory, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults(this TaskTemplateFactory parentFactory, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null)
    {
        var factory = new InnerTaskTemplateDefaultFieldValueFactory(subFactoryAction);
        parentFactory.DefaultsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TaskTemplateFactory, InnerTaskTemplateFieldFactory> WithFields(this TaskTemplateFactory parentFactory, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null)
    {
        var factory = new InnerTaskTemplateFieldFactory(subFactoryAction);
        parentFactory.FieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TaskTemplateFactory, InnerTaskTemplateConstraintsFactory> WithConstraints(this TaskTemplateFactory parentFactory, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerTaskTemplateConstraintsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<TaskTemplateFactory, T1, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1>(this CombinedResult<TaskTemplateFactory, T1> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1>(this CombinedResult<T1, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2>(this CombinedResult<TaskTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2>(this CombinedResult<T1, TaskTemplateFactory, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2>(this CombinedResult<T1, T2, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3>(this CombinedResult<TaskTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3>(this CombinedResult<T1, TaskTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3>(this CombinedResult<T1, T2, TaskTemplateFactory, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, T4, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3, T4>(this CombinedResult<TaskTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, T4, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3, T4>(this CombinedResult<T1, TaskTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, T4, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, T4, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskTemplateFactory, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskTemplateFactory, InnerTaskTemplateDefaultFieldValueFactory> WithDefaults<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.DefaultFieldValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaults(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, InnerTaskTemplateFieldFactory> WithFields<T1>(this CombinedResult<TaskTemplateFactory, T1> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, InnerTaskTemplateFieldFactory> WithFields<T1>(this CombinedResult<T1, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, InnerTaskTemplateFieldFactory> WithFields<T1, T2>(this CombinedResult<TaskTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, InnerTaskTemplateFieldFactory> WithFields<T1, T2>(this CombinedResult<T1, TaskTemplateFactory, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, InnerTaskTemplateFieldFactory> WithFields<T1, T2>(this CombinedResult<T1, T2, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<TaskTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, TaskTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, TaskTemplateFactory, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, T4, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<TaskTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, T4, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, TaskTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, T4, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, T4, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskTemplateFactory, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskTemplateFactory, InnerTaskTemplateFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, InnerTaskTemplateConstraintsFactory> WithConstraints<T1>(this CombinedResult<TaskTemplateFactory, T1> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, InnerTaskTemplateConstraintsFactory> WithConstraints<T1>(this CombinedResult<T1, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<TaskTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, TaskTemplateFactory, T2> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<TaskTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, TaskTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, TaskTemplateFactory, T3> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskTemplateFactory, T1, T2, T3, T4, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<TaskTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskTemplateFactory, T2, T3, T4, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, TaskTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskTemplateFactory, T3, T4, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskTemplateFactory, T4, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskTemplateFactory, T4> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskTemplateFactory, InnerTaskTemplateConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskTemplateFactory> combinedResult, Action<Humidifier.Connect.TaskTemplateTypes.Constraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
}

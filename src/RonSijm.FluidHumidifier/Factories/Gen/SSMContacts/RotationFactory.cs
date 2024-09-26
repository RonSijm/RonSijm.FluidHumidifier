// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class RotationFactory(string resourceName = null, Action<Humidifier.SSMContacts.Rotation> factoryAction = null) : ResourceFactory<Humidifier.SSMContacts.Rotation>(resourceName)
{

    internal InnerRotationRecurrenceSettingsFactory RecurrenceFactory { get; set; }

    protected override Humidifier.SSMContacts.Rotation Create()
    {
        var rotationResult = CreateRotation();
        factoryAction?.Invoke(rotationResult);

        return rotationResult;
    }

    private Humidifier.SSMContacts.Rotation CreateRotation()
    {
        var rotationResult = new Humidifier.SSMContacts.Rotation
        {
            GivenName = InputResourceName,
        };

        return rotationResult;
    }
    public override void CreateChildren(Humidifier.SSMContacts.Rotation result)
    {
        base.CreateChildren(result);

        result.Recurrence ??= RecurrenceFactory?.Build();
    }

} // End Of Class

public static class RotationFactoryExtensions
{
    public static CombinedResult<RotationFactory, InnerRotationRecurrenceSettingsFactory> WithRecurrence(this RotationFactory parentFactory, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null)
    {
        parentFactory.RecurrenceFactory = new InnerRotationRecurrenceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecurrenceFactory);
    }

    public static CombinedResult<RotationFactory, T1, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1>(this CombinedResult<RotationFactory, T1> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrence(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationFactory, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1>(this CombinedResult<T1, RotationFactory> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrence(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RotationFactory, T1, T2, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2>(this CombinedResult<RotationFactory, T1, T2> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationFactory, T2, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2>(this CombinedResult<T1, RotationFactory, T2> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationFactory, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2>(this CombinedResult<T1, T2, RotationFactory> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RotationFactory, T1, T2, T3, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3>(this CombinedResult<RotationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationFactory, T2, T3, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3>(this CombinedResult<T1, RotationFactory, T2, T3> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationFactory, T3, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3>(this CombinedResult<T1, T2, RotationFactory, T3> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationFactory, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3>(this CombinedResult<T1, T2, T3, RotationFactory> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RotationFactory, T1, T2, T3, T4, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3, T4>(this CombinedResult<RotationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationFactory, T2, T3, T4, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3, T4>(this CombinedResult<T1, RotationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationFactory, T3, T4, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3, T4>(this CombinedResult<T1, T2, RotationFactory, T3, T4> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationFactory, T4, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RotationFactory, T4> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RotationFactory, InnerRotationRecurrenceSettingsFactory> WithRecurrence<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RotationFactory> combinedResult, Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrence(combinedResult.T5, subFactoryAction));
}

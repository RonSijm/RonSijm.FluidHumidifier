// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMGuiConnect;

public class InnerPreferencesConnectionRecordingPreferencesFactory(Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> factoryAction = null) : SubResourceFactory<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences>
{

    internal InnerPreferencesRecordingDestinationsFactory RecordingDestinationsFactory { get; set; }

    protected override Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences Create()
    {
        var connectionRecordingPreferencesResult = CreateConnectionRecordingPreferences();
        factoryAction?.Invoke(connectionRecordingPreferencesResult);

        return connectionRecordingPreferencesResult;
    }

    private Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences CreateConnectionRecordingPreferences()
    {
        var connectionRecordingPreferencesResult = new Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences();

        return connectionRecordingPreferencesResult;
    }
    public override void CreateChildren(Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences result)
    {
        base.CreateChildren(result);

        result.RecordingDestinations ??= RecordingDestinationsFactory?.Build();
    }

} // End Of Class

public static class InnerPreferencesConnectionRecordingPreferencesFactoryExtensions
{
    public static CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations(this InnerPreferencesConnectionRecordingPreferencesFactory parentFactory, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null)
    {
        parentFactory.RecordingDestinationsFactory = new InnerPreferencesRecordingDestinationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordingDestinationsFactory);
    }

    public static CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1>(this CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1>(this CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2>(this CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2>(this CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2>(this CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2, T3, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3>(this CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2, T3, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3>(this CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory, T3, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3>(this CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2, T3, T4, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3, T4>(this CombinedResult<InnerPreferencesConnectionRecordingPreferencesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2, T3, T4, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3, T4>(this CombinedResult<T1, InnerPreferencesConnectionRecordingPreferencesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory, T3, T4, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory, T4, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPreferencesConnectionRecordingPreferencesFactory, InnerPreferencesRecordingDestinationsFactory> WithRecordingDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPreferencesConnectionRecordingPreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordingDestinations(combinedResult.T5, subFactoryAction).T2);
}

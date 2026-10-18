// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMGuiConnect;

public class PreferencesFactory(string resourceName = null, Action<Humidifier.SSMGuiConnect.Preferences> factoryAction = null) : ResourceFactory<Humidifier.SSMGuiConnect.Preferences>(resourceName)
{

    internal InnerPreferencesConnectionRecordingPreferencesFactory ConnectionRecordingPreferencesFactory { get; set; }

    protected override Humidifier.SSMGuiConnect.Preferences Create()
    {
        var preferencesResult = CreatePreferences();
        factoryAction?.Invoke(preferencesResult);

        return preferencesResult;
    }

    private Humidifier.SSMGuiConnect.Preferences CreatePreferences()
    {
        var preferencesResult = new Humidifier.SSMGuiConnect.Preferences
        {
            GivenName = InputResourceName,
        };

        return preferencesResult;
    }
    public override void CreateChildren(Humidifier.SSMGuiConnect.Preferences result)
    {
        base.CreateChildren(result);

        result.ConnectionRecordingPreferences ??= ConnectionRecordingPreferencesFactory?.Build();
    }

} // End Of Class

public static class PreferencesFactoryExtensions
{
    public static CombinedResult<PreferencesFactory, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences(this PreferencesFactory parentFactory, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null)
    {
        parentFactory.ConnectionRecordingPreferencesFactory = new InnerPreferencesConnectionRecordingPreferencesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionRecordingPreferencesFactory);
    }

    public static CombinedResult<PreferencesFactory, T1, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1>(this CombinedResult<PreferencesFactory, T1> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PreferencesFactory, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1>(this CombinedResult<T1, PreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PreferencesFactory, T1, T2, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2>(this CombinedResult<PreferencesFactory, T1, T2> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PreferencesFactory, T2, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2>(this CombinedResult<T1, PreferencesFactory, T2> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PreferencesFactory, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2>(this CombinedResult<T1, T2, PreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PreferencesFactory, T1, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3>(this CombinedResult<PreferencesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PreferencesFactory, T2, T3, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3>(this CombinedResult<T1, PreferencesFactory, T2, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PreferencesFactory, T3, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3>(this CombinedResult<T1, T2, PreferencesFactory, T3> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PreferencesFactory, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3>(this CombinedResult<T1, T2, T3, PreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PreferencesFactory, T1, T2, T3, T4, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3, T4>(this CombinedResult<PreferencesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PreferencesFactory, T2, T3, T4, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3, T4>(this CombinedResult<T1, PreferencesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PreferencesFactory, T3, T4, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, PreferencesFactory, T3, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PreferencesFactory, T4, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PreferencesFactory, T4> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PreferencesFactory, InnerPreferencesConnectionRecordingPreferencesFactory> WithConnectionRecordingPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PreferencesFactory> combinedResult, Action<Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionRecordingPreferences(combinedResult.T5, subFactoryAction).T2);
}

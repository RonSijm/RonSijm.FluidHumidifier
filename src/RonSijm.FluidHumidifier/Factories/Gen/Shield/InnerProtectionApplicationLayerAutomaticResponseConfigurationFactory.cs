// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory(Action<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration>
{

    internal InnerProtectionActionFactory ActionFactory { get; set; }

    protected override Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration Create()
    {
        var applicationLayerAutomaticResponseConfigurationResult = CreateApplicationLayerAutomaticResponseConfiguration();
        factoryAction?.Invoke(applicationLayerAutomaticResponseConfigurationResult);

        return applicationLayerAutomaticResponseConfigurationResult;
    }

    private Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration CreateApplicationLayerAutomaticResponseConfiguration()
    {
        var applicationLayerAutomaticResponseConfigurationResult = new Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration();

        return applicationLayerAutomaticResponseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerProtectionApplicationLayerAutomaticResponseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, InnerProtectionActionFactory> WithAction(this InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory parentFactory, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerProtectionActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, InnerProtectionActionFactory> WithAction<T1>(this CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, InnerProtectionActionFactory> WithAction<T1>(this CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2, InnerProtectionActionFactory> WithAction<T1, T2>(this CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2, InnerProtectionActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, InnerProtectionActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2, T3, InnerProtectionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2, T3, InnerProtectionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T3, InnerProtectionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T3> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, InnerProtectionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2, T3, T4, InnerProtectionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2, T3, T4, InnerProtectionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T3, T4, InnerProtectionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T4, InnerProtectionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, T4> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory, InnerProtectionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProtectionApplicationLayerAutomaticResponseConfigurationFactory> combinedResult, Action<Humidifier.Shield.ProtectionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}

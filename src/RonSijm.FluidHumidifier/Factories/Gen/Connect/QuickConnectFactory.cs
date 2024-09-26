// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class QuickConnectFactory(string resourceName = null, Action<Humidifier.Connect.QuickConnect> factoryAction = null) : ResourceFactory<Humidifier.Connect.QuickConnect>(resourceName)
{

    internal InnerQuickConnectQuickConnectConfigFactory QuickConnectConfigFactory { get; set; }

    protected override Humidifier.Connect.QuickConnect Create()
    {
        var quickConnectResult = CreateQuickConnect();
        factoryAction?.Invoke(quickConnectResult);

        return quickConnectResult;
    }

    private Humidifier.Connect.QuickConnect CreateQuickConnect()
    {
        var quickConnectResult = new Humidifier.Connect.QuickConnect
        {
            GivenName = InputResourceName,
        };

        return quickConnectResult;
    }
    public override void CreateChildren(Humidifier.Connect.QuickConnect result)
    {
        base.CreateChildren(result);

        result.QuickConnectConfig ??= QuickConnectConfigFactory?.Build();
    }

} // End Of Class

public static class QuickConnectFactoryExtensions
{
    public static CombinedResult<QuickConnectFactory, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig(this QuickConnectFactory parentFactory, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null)
    {
        parentFactory.QuickConnectConfigFactory = new InnerQuickConnectQuickConnectConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QuickConnectConfigFactory);
    }

    public static CombinedResult<QuickConnectFactory, T1, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1>(this CombinedResult<QuickConnectFactory, T1> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QuickConnectFactory, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1>(this CombinedResult<T1, QuickConnectFactory> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<QuickConnectFactory, T1, T2, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2>(this CombinedResult<QuickConnectFactory, T1, T2> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QuickConnectFactory, T2, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2>(this CombinedResult<T1, QuickConnectFactory, T2> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QuickConnectFactory, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2>(this CombinedResult<T1, T2, QuickConnectFactory> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<QuickConnectFactory, T1, T2, T3, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3>(this CombinedResult<QuickConnectFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QuickConnectFactory, T2, T3, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3>(this CombinedResult<T1, QuickConnectFactory, T2, T3> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QuickConnectFactory, T3, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3>(this CombinedResult<T1, T2, QuickConnectFactory, T3> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QuickConnectFactory, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, QuickConnectFactory> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<QuickConnectFactory, T1, T2, T3, T4, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3, T4>(this CombinedResult<QuickConnectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QuickConnectFactory, T2, T3, T4, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3, T4>(this CombinedResult<T1, QuickConnectFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QuickConnectFactory, T3, T4, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, QuickConnectFactory, T3, T4> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QuickConnectFactory, T4, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QuickConnectFactory, T4> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, QuickConnectFactory, InnerQuickConnectQuickConnectConfigFactory> WithQuickConnectConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QuickConnectFactory> combinedResult, Action<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuickConnectConfig(combinedResult.T5, subFactoryAction));
}

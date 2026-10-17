// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class AppInstanceBotFactory(string resourceName = null, Action<Humidifier.Chime.AppInstanceBot> factoryAction = null) : ResourceFactory<Humidifier.Chime.AppInstanceBot>(resourceName)
{

    internal InnerAppInstanceBotConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Chime.AppInstanceBot Create()
    {
        var appInstanceBotResult = CreateAppInstanceBot();
        factoryAction?.Invoke(appInstanceBotResult);

        return appInstanceBotResult;
    }

    private Humidifier.Chime.AppInstanceBot CreateAppInstanceBot()
    {
        var appInstanceBotResult = new Humidifier.Chime.AppInstanceBot
        {
            GivenName = InputResourceName,
        };

        return appInstanceBotResult;
    }
    public override void CreateChildren(Humidifier.Chime.AppInstanceBot result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class AppInstanceBotFactoryExtensions
{
    public static CombinedResult<AppInstanceBotFactory, InnerAppInstanceBotConfigurationFactory> WithConfiguration(this AppInstanceBotFactory parentFactory, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAppInstanceBotConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<AppInstanceBotFactory, T1, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1>(this CombinedResult<AppInstanceBotFactory, T1> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceBotFactory, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, AppInstanceBotFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AppInstanceBotFactory, T1, T2, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<AppInstanceBotFactory, T1, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceBotFactory, T2, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, AppInstanceBotFactory, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceBotFactory, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, AppInstanceBotFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AppInstanceBotFactory, T1, T2, T3, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<AppInstanceBotFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceBotFactory, T2, T3, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, AppInstanceBotFactory, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceBotFactory, T3, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AppInstanceBotFactory, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppInstanceBotFactory, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppInstanceBotFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AppInstanceBotFactory, T1, T2, T3, T4, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<AppInstanceBotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceBotFactory, T2, T3, T4, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AppInstanceBotFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceBotFactory, T3, T4, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppInstanceBotFactory, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppInstanceBotFactory, T4, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppInstanceBotFactory, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AppInstanceBotFactory, InnerAppInstanceBotConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppInstanceBotFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}

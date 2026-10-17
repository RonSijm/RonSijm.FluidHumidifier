// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerAppInstanceBotConfigurationFactory(Action<Humidifier.Chime.AppInstanceBotTypes.Configuration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.AppInstanceBotTypes.Configuration>
{

    internal InnerAppInstanceBotLexConfigurationFactory LexFactory { get; set; }

    protected override Humidifier.Chime.AppInstanceBotTypes.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.Chime.AppInstanceBotTypes.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.Chime.AppInstanceBotTypes.Configuration();

        return configurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.AppInstanceBotTypes.Configuration result)
    {
        base.CreateChildren(result);

        result.Lex ??= LexFactory?.Build();
    }

} // End Of Class

public static class InnerAppInstanceBotConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAppInstanceBotConfigurationFactory, InnerAppInstanceBotLexConfigurationFactory> WithLex(this InnerAppInstanceBotConfigurationFactory parentFactory, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null)
    {
        parentFactory.LexFactory = new InnerAppInstanceBotLexConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LexFactory);
    }

    public static CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1>(this CombinedResult<InnerAppInstanceBotConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1>(this CombinedResult<T1, InnerAppInstanceBotConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2>(this CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2>(this CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2>(this CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2, T3, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3>(this CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2, T3, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3>(this CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory, T3, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppInstanceBotConfigurationFactory, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppInstanceBotConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2, T3, T4, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3, T4>(this CombinedResult<InnerAppInstanceBotConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2, T3, T4, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppInstanceBotConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory, T3, T4, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppInstanceBotConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppInstanceBotConfigurationFactory, T4, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppInstanceBotConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAppInstanceBotConfigurationFactory, InnerAppInstanceBotLexConfigurationFactory> WithLex<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppInstanceBotConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLex(combinedResult.T5, subFactoryAction).T2);
}

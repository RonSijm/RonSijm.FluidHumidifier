// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerAppInstanceBotLexConfigurationFactory(Action<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration>
{

    internal InnerAppInstanceBotInvokedByFactory InvokedByFactory { get; set; }

    protected override Humidifier.Chime.AppInstanceBotTypes.LexConfiguration Create()
    {
        var lexConfigurationResult = CreateLexConfiguration();
        factoryAction?.Invoke(lexConfigurationResult);

        return lexConfigurationResult;
    }

    private Humidifier.Chime.AppInstanceBotTypes.LexConfiguration CreateLexConfiguration()
    {
        var lexConfigurationResult = new Humidifier.Chime.AppInstanceBotTypes.LexConfiguration();

        return lexConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Chime.AppInstanceBotTypes.LexConfiguration result)
    {
        base.CreateChildren(result);

        result.InvokedBy ??= InvokedByFactory?.Build();
    }

} // End Of Class

public static class InnerAppInstanceBotLexConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAppInstanceBotLexConfigurationFactory, InnerAppInstanceBotInvokedByFactory> WithInvokedBy(this InnerAppInstanceBotLexConfigurationFactory parentFactory, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null)
    {
        parentFactory.InvokedByFactory = new InnerAppInstanceBotInvokedByFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InvokedByFactory);
    }

    public static CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1>(this CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvokedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1>(this CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvokedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2>(this CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2>(this CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2>(this CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2, T3, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3>(this CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2, T3, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3>(this CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory, T3, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory, T3> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppInstanceBotLexConfigurationFactory, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppInstanceBotLexConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2, T3, T4, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3, T4>(this CombinedResult<InnerAppInstanceBotLexConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2, T3, T4, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppInstanceBotLexConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory, T3, T4, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppInstanceBotLexConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppInstanceBotLexConfigurationFactory, T4, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppInstanceBotLexConfigurationFactory, T4> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAppInstanceBotLexConfigurationFactory, InnerAppInstanceBotInvokedByFactory> WithInvokedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppInstanceBotLexConfigurationFactory> combinedResult, Action<Humidifier.Chime.AppInstanceBotTypes.InvokedBy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokedBy(combinedResult.T5, subFactoryAction).T2);
}

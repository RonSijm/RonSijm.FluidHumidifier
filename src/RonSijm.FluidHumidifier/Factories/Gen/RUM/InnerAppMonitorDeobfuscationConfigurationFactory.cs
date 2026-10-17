// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class InnerAppMonitorDeobfuscationConfigurationFactory(Action<Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration>
{

    internal InnerAppMonitorJavaScriptSourceMapsFactory JavaScriptSourceMapsFactory { get; set; }

    protected override Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration Create()
    {
        var deobfuscationConfigurationResult = CreateDeobfuscationConfiguration();
        factoryAction?.Invoke(deobfuscationConfigurationResult);

        return deobfuscationConfigurationResult;
    }

    private Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration CreateDeobfuscationConfiguration()
    {
        var deobfuscationConfigurationResult = new Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration();

        return deobfuscationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration result)
    {
        base.CreateChildren(result);

        result.JavaScriptSourceMaps ??= JavaScriptSourceMapsFactory?.Build();
    }

} // End Of Class

public static class InnerAppMonitorDeobfuscationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps(this InnerAppMonitorDeobfuscationConfigurationFactory parentFactory, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null)
    {
        parentFactory.JavaScriptSourceMapsFactory = new InnerAppMonitorJavaScriptSourceMapsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JavaScriptSourceMapsFactory);
    }

    public static CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1>(this CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1>(this CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2>(this CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2>(this CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2>(this CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2, T3, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3>(this CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2, T3, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3>(this CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory, T3, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppMonitorDeobfuscationConfigurationFactory, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppMonitorDeobfuscationConfigurationFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2, T3, T4, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3, T4>(this CombinedResult<InnerAppMonitorDeobfuscationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2, T3, T4, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppMonitorDeobfuscationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory, T3, T4, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppMonitorDeobfuscationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppMonitorDeobfuscationConfigurationFactory, T4, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppMonitorDeobfuscationConfigurationFactory, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAppMonitorDeobfuscationConfigurationFactory, InnerAppMonitorJavaScriptSourceMapsFactory> WithJavaScriptSourceMaps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppMonitorDeobfuscationConfigurationFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJavaScriptSourceMaps(combinedResult.T5, subFactoryAction).T2);
}

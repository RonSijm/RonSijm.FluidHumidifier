// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceCodeConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.CodeConfiguration>
{

    internal InnerServiceCodeConfigurationValuesFactory CodeConfigurationValuesFactory { get; set; }

    protected override Humidifier.AppRunner.ServiceTypes.CodeConfiguration Create()
    {
        var codeConfigurationResult = CreateCodeConfiguration();
        factoryAction?.Invoke(codeConfigurationResult);

        return codeConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.CodeConfiguration CreateCodeConfiguration()
    {
        var codeConfigurationResult = new Humidifier.AppRunner.ServiceTypes.CodeConfiguration();

        return codeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.ServiceTypes.CodeConfiguration result)
    {
        base.CreateChildren(result);

        result.CodeConfigurationValues ??= CodeConfigurationValuesFactory?.Build();
    }

} // End Of Class

public static class InnerServiceCodeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceCodeConfigurationFactory, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues(this InnerServiceCodeConfigurationFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null)
    {
        parentFactory.CodeConfigurationValuesFactory = new InnerServiceCodeConfigurationValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeConfigurationValuesFactory);
    }

    public static CombinedResult<InnerServiceCodeConfigurationFactory, T1, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1>(this CombinedResult<InnerServiceCodeConfigurationFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeConfigurationFactory, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1>(this CombinedResult<T1, InnerServiceCodeConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2>(this CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2>(this CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2>(this CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2, T3, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3>(this CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2, T3, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3>(this CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory, T3, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeConfigurationFactory, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceCodeConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2, T3, T4, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3, T4>(this CombinedResult<InnerServiceCodeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2, T3, T4, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceCodeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory, T3, T4, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceCodeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeConfigurationFactory, T4, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceCodeConfigurationFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceCodeConfigurationFactory, InnerServiceCodeConfigurationValuesFactory> WithCodeConfigurationValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceCodeConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfigurationValues(combinedResult.T5, subFactoryAction));
}

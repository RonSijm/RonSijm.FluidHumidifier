// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionFunctionFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.Function>
{

    internal InnerFunctionDefinitionFunctionConfigurationFactory FunctionConfigurationFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.Function Create()
    {
        var functionResult = CreateFunction();
        factoryAction?.Invoke(functionResult);

        return functionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.Function CreateFunction()
    {
        var functionResult = new Humidifier.Greengrass.FunctionDefinitionTypes.Function();

        return functionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.Function result)
    {
        base.CreateChildren(result);

        result.FunctionConfiguration ??= FunctionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionFunctionFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionFunctionFactory, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration(this InnerFunctionDefinitionFunctionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null)
    {
        parentFactory.FunctionConfigurationFactory = new InnerFunctionDefinitionFunctionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FunctionConfigurationFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1>(this CombinedResult<InnerFunctionDefinitionFunctionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1>(this CombinedResult<T1, InnerFunctionDefinitionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory, T3, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionFactory, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2, T3, T4, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionFunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2, T3, T4, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionFunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory, T3, T4, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionFactory, T4, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionFactory, InnerFunctionDefinitionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T5, subFactoryAction));
}

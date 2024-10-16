// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionFunctionFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function>
{

    internal InnerFunctionDefinitionVersionFunctionConfigurationFactory FunctionConfigurationFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function Create()
    {
        var functionResult = CreateFunction();
        factoryAction?.Invoke(functionResult);

        return functionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function CreateFunction()
    {
        var functionResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function();

        return functionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function result)
    {
        base.CreateChildren(result);

        result.FunctionConfiguration ??= FunctionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionFunctionFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration(this InnerFunctionDefinitionVersionFunctionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null)
    {
        parentFactory.FunctionConfigurationFactory = new InnerFunctionDefinitionVersionFunctionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FunctionConfigurationFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1>(this CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionFactory, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionVersionFunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2, T3, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory, T3, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionFactory, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionFactory, InnerFunctionDefinitionVersionFunctionConfigurationFactory> WithFunctionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfiguration(combinedResult.T5, subFactoryAction));
}

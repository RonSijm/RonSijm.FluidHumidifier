// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionFunctionDefinitionVersionFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion>
{

    internal List<InnerFunctionDefinitionFunctionFactory> FunctionsFactories { get; set; } = [];

    internal InnerFunctionDefinitionDefaultConfigFactory DefaultConfigFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion Create()
    {
        var functionDefinitionVersionResult = CreateFunctionDefinitionVersion();
        factoryAction?.Invoke(functionDefinitionVersionResult);

        return functionDefinitionVersionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion CreateFunctionDefinitionVersion()
    {
        var functionDefinitionVersionResult = new Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion();

        return functionDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Functions = FunctionsFactories.Any() ? FunctionsFactories.Select(x => x.Build()).ToList() : null;
        result.DefaultConfig ??= DefaultConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionFunctionDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionFunctionFactory> WithFunctions(this InnerFunctionDefinitionFunctionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null)
    {
        var factory = new InnerFunctionDefinitionFunctionFactory(subFactoryAction);
        parentFactory.FunctionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig(this InnerFunctionDefinitionFunctionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null)
    {
        parentFactory.DefaultConfigFactory = new InnerFunctionDefinitionDefaultConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultConfigFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, T4, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, T4, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, T4, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T4, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, T4, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionFunctionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, T4, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, T4, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T4, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory, InnerFunctionDefinitionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T5, subFactoryAction));
}

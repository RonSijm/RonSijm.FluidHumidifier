// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class FunctionDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.FunctionDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersion>(resourceName)
{

    internal List<InnerFunctionDefinitionVersionFunctionFactory> FunctionsFactories { get; set; } = [];

    internal InnerFunctionDefinitionVersionDefaultConfigFactory DefaultConfigFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersion Create()
    {
        var functionDefinitionVersionResult = CreateFunctionDefinitionVersion();
        factoryAction?.Invoke(functionDefinitionVersionResult);

        return functionDefinitionVersionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersion CreateFunctionDefinitionVersion()
    {
        var functionDefinitionVersionResult = new Humidifier.Greengrass.FunctionDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return functionDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Functions = FunctionsFactories.Any() ? FunctionsFactories.Select(x => x.Build()).ToList() : null;
        result.DefaultConfig ??= DefaultConfigFactory?.Build();
    }

} // End Of Class

public static class FunctionDefinitionVersionFactoryExtensions
{
    public static CombinedResult<FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions(this FunctionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null)
    {
        var factory = new InnerFunctionDefinitionVersionFunctionFactory(subFactoryAction);
        parentFactory.FunctionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig(this FunctionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null)
    {
        parentFactory.DefaultConfigFactory = new InnerFunctionDefinitionVersionDefaultConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultConfigFactory);
    }

    public static CombinedResult<FunctionDefinitionVersionFactory, T1, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1>(this CombinedResult<FunctionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1>(this CombinedResult<T1, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, T4, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, T4, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, T4, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionFunctionFactory> WithFunctions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1>(this CombinedResult<FunctionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1>(this CombinedResult<T1, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<FunctionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, T4, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, FunctionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, T4, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, T4, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionDefinitionVersionFactory, InnerFunctionDefinitionVersionDefaultConfigFactory> WithDefaultConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultConfig(combinedResult.T5, subFactoryAction));
}

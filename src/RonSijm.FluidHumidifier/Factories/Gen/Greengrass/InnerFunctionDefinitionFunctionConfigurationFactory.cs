// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionFunctionConfigurationFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration>
{

    internal InnerFunctionDefinitionEnvironmentFactory EnvironmentFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration Create()
    {
        var functionConfigurationResult = CreateFunctionConfiguration();
        factoryAction?.Invoke(functionConfigurationResult);

        return functionConfigurationResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration CreateFunctionConfiguration()
    {
        var functionConfigurationResult = new Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration();

        return functionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.FunctionConfiguration result)
    {
        base.CreateChildren(result);

        result.Environment ??= EnvironmentFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionFunctionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment(this InnerFunctionDefinitionFunctionConfigurationFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null)
    {
        parentFactory.EnvironmentFactory = new InnerFunctionDefinitionEnvironmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnvironmentFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1>(this CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1>(this CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2, T3, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2, T3, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory, T3, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2, T3, T4, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionFunctionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2, T3, T4, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionFunctionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory, T3, T4, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionFunctionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory, T4, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionFunctionConfigurationFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionConfigurationFactory, InnerFunctionDefinitionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T5, subFactoryAction));
}

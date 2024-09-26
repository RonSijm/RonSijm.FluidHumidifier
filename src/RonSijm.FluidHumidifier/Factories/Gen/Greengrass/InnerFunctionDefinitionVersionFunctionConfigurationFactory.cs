// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionFunctionConfigurationFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration>
{

    internal InnerFunctionDefinitionVersionEnvironmentFactory EnvironmentFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration Create()
    {
        var functionConfigurationResult = CreateFunctionConfiguration();
        factoryAction?.Invoke(functionConfigurationResult);

        return functionConfigurationResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration CreateFunctionConfiguration()
    {
        var functionConfigurationResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration();

        return functionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersionTypes.FunctionConfiguration result)
    {
        base.CreateChildren(result);

        result.Environment ??= EnvironmentFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionFunctionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment(this InnerFunctionDefinitionVersionFunctionConfigurationFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null)
    {
        parentFactory.EnvironmentFactory = new InnerFunctionDefinitionVersionEnvironmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnvironmentFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1>(this CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T3, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionVersionFunctionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2, T3, T4, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T3, T4, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T4, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionFunctionConfigurationFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory, InnerFunctionDefinitionVersionEnvironmentFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionFunctionConfigurationFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T5, subFactoryAction));
}

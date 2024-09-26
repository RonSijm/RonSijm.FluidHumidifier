// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class FunctionDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.FunctionDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.FunctionDefinition>(resourceName)
{

    internal InnerFunctionDefinitionFunctionDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinition Create()
    {
        var functionDefinitionResult = CreateFunctionDefinition();
        factoryAction?.Invoke(functionDefinitionResult);

        return functionDefinitionResult;
    }

    private Humidifier.Greengrass.FunctionDefinition CreateFunctionDefinition()
    {
        var functionDefinitionResult = new Humidifier.Greengrass.FunctionDefinition
        {
            GivenName = InputResourceName,
        };

        return functionDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class FunctionDefinitionFactoryExtensions
{
    public static CombinedResult<FunctionDefinitionFactory, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion(this FunctionDefinitionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerFunctionDefinitionFunctionDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<FunctionDefinitionFactory, T1, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<FunctionDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionFactory, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, FunctionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionDefinitionFactory, T1, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<FunctionDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionFactory, T2, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, FunctionDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionFactory, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, FunctionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionDefinitionFactory, T1, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<FunctionDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionFactory, T2, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, FunctionDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionFactory, T3, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, FunctionDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionFactory, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionDefinitionFactory, T1, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<FunctionDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionDefinitionFactory, T2, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, FunctionDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionDefinitionFactory, T3, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionDefinitionFactory, T4, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionDefinitionFactory, InnerFunctionDefinitionFunctionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.FunctionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}

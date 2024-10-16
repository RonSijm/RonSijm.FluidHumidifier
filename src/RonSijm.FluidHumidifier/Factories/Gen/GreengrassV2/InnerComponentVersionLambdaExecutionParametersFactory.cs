// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerComponentVersionLambdaExecutionParametersFactory(Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters>
{

    internal InnerComponentVersionLambdaLinuxProcessParamsFactory LinuxProcessParamsFactory { get; set; }

    protected override Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters Create()
    {
        var lambdaExecutionParametersResult = CreateLambdaExecutionParameters();
        factoryAction?.Invoke(lambdaExecutionParametersResult);

        return lambdaExecutionParametersResult;
    }

    private Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters CreateLambdaExecutionParameters()
    {
        var lambdaExecutionParametersResult = new Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters();

        return lambdaExecutionParametersResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters result)
    {
        base.CreateChildren(result);

        result.LinuxProcessParams ??= LinuxProcessParamsFactory?.Build();
    }

} // End Of Class

public static class InnerComponentVersionLambdaExecutionParametersFactoryExtensions
{
    public static CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams(this InnerComponentVersionLambdaExecutionParametersFactory parentFactory, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null)
    {
        parentFactory.LinuxProcessParamsFactory = new InnerComponentVersionLambdaLinuxProcessParamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinuxProcessParamsFactory);
    }

    public static CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1>(this CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1>(this CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2>(this CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2>(this CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2>(this CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3>(this CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3>(this CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3>(this CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2, T3, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3, T4>(this CombinedResult<InnerComponentVersionLambdaExecutionParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2, T3, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3, T4>(this CombinedResult<T1, InnerComponentVersionLambdaExecutionParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory, T3, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComponentVersionLambdaExecutionParametersFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaExecutionParametersFactory, InnerComponentVersionLambdaLinuxProcessParamsFactory> WithLinuxProcessParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaExecutionParametersFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinuxProcessParams(combinedResult.T5, subFactoryAction));
}

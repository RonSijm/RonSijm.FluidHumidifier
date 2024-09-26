// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerComponentVersionLambdaLinuxProcessParamsFactory(Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams>
{

    internal InnerComponentVersionLambdaContainerParamsFactory ContainerParamsFactory { get; set; }

    protected override Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams Create()
    {
        var lambdaLinuxProcessParamsResult = CreateLambdaLinuxProcessParams();
        factoryAction?.Invoke(lambdaLinuxProcessParamsResult);

        return lambdaLinuxProcessParamsResult;
    }

    private Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams CreateLambdaLinuxProcessParams()
    {
        var lambdaLinuxProcessParamsResult = new Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams();

        return lambdaLinuxProcessParamsResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.ComponentVersionTypes.LambdaLinuxProcessParams result)
    {
        base.CreateChildren(result);

        result.ContainerParams ??= ContainerParamsFactory?.Build();
    }

} // End Of Class

public static class InnerComponentVersionLambdaLinuxProcessParamsFactoryExtensions
{
    public static CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams(this InnerComponentVersionLambdaLinuxProcessParamsFactory parentFactory, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null)
    {
        parentFactory.ContainerParamsFactory = new InnerComponentVersionLambdaContainerParamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerParamsFactory);
    }

    public static CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1>(this CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1>(this CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2>(this CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2>(this CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2>(this CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2, T3, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3>(this CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2, T3, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3>(this CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory, T3, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3>(this CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2, T3, T4, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3, T4>(this CombinedResult<InnerComponentVersionLambdaLinuxProcessParamsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2, T3, T4, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3, T4>(this CombinedResult<T1, InnerComponentVersionLambdaLinuxProcessParamsFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory, T3, T4, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComponentVersionLambdaLinuxProcessParamsFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory, T4, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaLinuxProcessParamsFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory, InnerComponentVersionLambdaContainerParamsFactory> WithContainerParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaLinuxProcessParamsFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerParams(combinedResult.T5, subFactoryAction));
}

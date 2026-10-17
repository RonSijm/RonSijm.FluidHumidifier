// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobAlgorithmSpecificationFactory(Action<Humidifier.Braket.JobTypes.AlgorithmSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.AlgorithmSpecification>
{

    internal InnerJobScriptModeConfigFactory ScriptModeConfigFactory { get; set; }

    protected override Humidifier.Braket.JobTypes.AlgorithmSpecification Create()
    {
        var algorithmSpecificationResult = CreateAlgorithmSpecification();
        factoryAction?.Invoke(algorithmSpecificationResult);

        return algorithmSpecificationResult;
    }

    private Humidifier.Braket.JobTypes.AlgorithmSpecification CreateAlgorithmSpecification()
    {
        var algorithmSpecificationResult = new Humidifier.Braket.JobTypes.AlgorithmSpecification();

        return algorithmSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Braket.JobTypes.AlgorithmSpecification result)
    {
        base.CreateChildren(result);

        result.ScriptModeConfig ??= ScriptModeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerJobAlgorithmSpecificationFactoryExtensions
{
    public static CombinedResult<InnerJobAlgorithmSpecificationFactory, InnerJobScriptModeConfigFactory> WithScriptModeConfig(this InnerJobAlgorithmSpecificationFactory parentFactory, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null)
    {
        parentFactory.ScriptModeConfigFactory = new InnerJobScriptModeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScriptModeConfigFactory);
    }

    public static CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1>(this CombinedResult<InnerJobAlgorithmSpecificationFactory, T1> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1>(this CombinedResult<T1, InnerJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2>(this CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2>(this CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2>(this CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2, T3, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3>(this CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2, T3, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3>(this CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory, T3, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory, T3> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobAlgorithmSpecificationFactory, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2, T3, T4, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3, T4>(this CombinedResult<InnerJobAlgorithmSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2, T3, T4, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobAlgorithmSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory, T3, T4, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobAlgorithmSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobAlgorithmSpecificationFactory, T4, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobAlgorithmSpecificationFactory, T4> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobAlgorithmSpecificationFactory, InnerJobScriptModeConfigFactory> WithScriptModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobAlgorithmSpecificationFactory> combinedResult, Action<Humidifier.Braket.JobTypes.ScriptModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptModeConfig(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerRemediationConfigurationExecutionControlsFactory(Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> factoryAction = null) : SubResourceFactory<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls>
{

    internal InnerRemediationConfigurationSsmControlsFactory SsmControlsFactory { get; set; }

    protected override Humidifier.Config.RemediationConfigurationTypes.ExecutionControls Create()
    {
        var executionControlsResult = CreateExecutionControls();
        factoryAction?.Invoke(executionControlsResult);

        return executionControlsResult;
    }

    private Humidifier.Config.RemediationConfigurationTypes.ExecutionControls CreateExecutionControls()
    {
        var executionControlsResult = new Humidifier.Config.RemediationConfigurationTypes.ExecutionControls();

        return executionControlsResult;
    }
    public override void CreateChildren(Humidifier.Config.RemediationConfigurationTypes.ExecutionControls result)
    {
        base.CreateChildren(result);

        result.SsmControls ??= SsmControlsFactory?.Build();
    }

} // End Of Class

public static class InnerRemediationConfigurationExecutionControlsFactoryExtensions
{
    public static CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls(this InnerRemediationConfigurationExecutionControlsFactory parentFactory, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null)
    {
        parentFactory.SsmControlsFactory = new InnerRemediationConfigurationSsmControlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SsmControlsFactory);
    }

    public static CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1>(this CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1>(this CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2>(this CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2>(this CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2>(this CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2, T3, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3>(this CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2, T3, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3>(this CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory, T3, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3>(this CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRemediationConfigurationExecutionControlsFactory, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRemediationConfigurationExecutionControlsFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2, T3, T4, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3, T4>(this CombinedResult<InnerRemediationConfigurationExecutionControlsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2, T3, T4, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3, T4>(this CombinedResult<T1, InnerRemediationConfigurationExecutionControlsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory, T3, T4, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRemediationConfigurationExecutionControlsFactory, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRemediationConfigurationExecutionControlsFactory, T4, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRemediationConfigurationExecutionControlsFactory, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRemediationConfigurationExecutionControlsFactory, InnerRemediationConfigurationSsmControlsFactory> WithSsmControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRemediationConfigurationExecutionControlsFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmControls(combinedResult.T5, subFactoryAction));
}

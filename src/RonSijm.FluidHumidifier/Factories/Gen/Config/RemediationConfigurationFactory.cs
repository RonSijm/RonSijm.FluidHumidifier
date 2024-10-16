// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class RemediationConfigurationFactory(string resourceName = null, Action<Humidifier.Config.RemediationConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Config.RemediationConfiguration>(resourceName)
{

    internal InnerRemediationConfigurationExecutionControlsFactory ExecutionControlsFactory { get; set; }

    protected override Humidifier.Config.RemediationConfiguration Create()
    {
        var remediationConfigurationResult = CreateRemediationConfiguration();
        factoryAction?.Invoke(remediationConfigurationResult);

        return remediationConfigurationResult;
    }

    private Humidifier.Config.RemediationConfiguration CreateRemediationConfiguration()
    {
        var remediationConfigurationResult = new Humidifier.Config.RemediationConfiguration
        {
            GivenName = InputResourceName,
        };

        return remediationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Config.RemediationConfiguration result)
    {
        base.CreateChildren(result);

        result.ExecutionControls ??= ExecutionControlsFactory?.Build();
    }

} // End Of Class

public static class RemediationConfigurationFactoryExtensions
{
    public static CombinedResult<RemediationConfigurationFactory, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls(this RemediationConfigurationFactory parentFactory, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null)
    {
        parentFactory.ExecutionControlsFactory = new InnerRemediationConfigurationExecutionControlsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionControlsFactory);
    }

    public static CombinedResult<RemediationConfigurationFactory, T1, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1>(this CombinedResult<RemediationConfigurationFactory, T1> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutionControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RemediationConfigurationFactory, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1>(this CombinedResult<T1, RemediationConfigurationFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutionControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RemediationConfigurationFactory, T1, T2, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2>(this CombinedResult<RemediationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RemediationConfigurationFactory, T2, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2>(this CombinedResult<T1, RemediationConfigurationFactory, T2> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RemediationConfigurationFactory, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2>(this CombinedResult<T1, T2, RemediationConfigurationFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RemediationConfigurationFactory, T1, T2, T3, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3>(this CombinedResult<RemediationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RemediationConfigurationFactory, T2, T3, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3>(this CombinedResult<T1, RemediationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RemediationConfigurationFactory, T3, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3>(this CombinedResult<T1, T2, RemediationConfigurationFactory, T3> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RemediationConfigurationFactory, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3>(this CombinedResult<T1, T2, T3, RemediationConfigurationFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RemediationConfigurationFactory, T1, T2, T3, T4, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3, T4>(this CombinedResult<RemediationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RemediationConfigurationFactory, T2, T3, T4, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3, T4>(this CombinedResult<T1, RemediationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RemediationConfigurationFactory, T3, T4, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, RemediationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RemediationConfigurationFactory, T4, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RemediationConfigurationFactory, T4> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RemediationConfigurationFactory, InnerRemediationConfigurationExecutionControlsFactory> WithExecutionControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RemediationConfigurationFactory> combinedResult, Action<Humidifier.Config.RemediationConfigurationTypes.ExecutionControls> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionControls(combinedResult.T5, subFactoryAction));
}

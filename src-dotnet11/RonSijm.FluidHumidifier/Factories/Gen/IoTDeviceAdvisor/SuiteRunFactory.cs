// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTDeviceAdvisor;

public class SuiteRunFactory(string resourceName = null, Action<Humidifier.IoTDeviceAdvisor.SuiteRun> factoryAction = null) : ResourceFactory<Humidifier.IoTDeviceAdvisor.SuiteRun>(resourceName)
{

    internal InnerSuiteRunSuiteRunConfigurationFactory SuiteRunConfigurationFactory { get; set; }

    protected override Humidifier.IoTDeviceAdvisor.SuiteRun Create()
    {
        var suiteRunResult = CreateSuiteRun();
        factoryAction?.Invoke(suiteRunResult);

        return suiteRunResult;
    }

    private Humidifier.IoTDeviceAdvisor.SuiteRun CreateSuiteRun()
    {
        var suiteRunResult = new Humidifier.IoTDeviceAdvisor.SuiteRun
        {
            GivenName = InputResourceName,
        };

        return suiteRunResult;
    }
    public override void CreateChildren(Humidifier.IoTDeviceAdvisor.SuiteRun result)
    {
        base.CreateChildren(result);

        result.SuiteRunConfiguration ??= SuiteRunConfigurationFactory?.Build();
    }

} // End Of Class

public static class SuiteRunFactoryExtensions
{
    public static CombinedResult<SuiteRunFactory, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration(this SuiteRunFactory parentFactory, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null)
    {
        parentFactory.SuiteRunConfigurationFactory = new InnerSuiteRunSuiteRunConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SuiteRunConfigurationFactory);
    }

    public static CombinedResult<SuiteRunFactory, T1, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1>(this CombinedResult<SuiteRunFactory, T1> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SuiteRunFactory, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1>(this CombinedResult<T1, SuiteRunFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SuiteRunFactory, T1, T2, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2>(this CombinedResult<SuiteRunFactory, T1, T2> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SuiteRunFactory, T2, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2>(this CombinedResult<T1, SuiteRunFactory, T2> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SuiteRunFactory, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2>(this CombinedResult<T1, T2, SuiteRunFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SuiteRunFactory, T1, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3>(this CombinedResult<SuiteRunFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SuiteRunFactory, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3>(this CombinedResult<T1, SuiteRunFactory, T2, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SuiteRunFactory, T3, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SuiteRunFactory, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SuiteRunFactory, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SuiteRunFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SuiteRunFactory, T1, T2, T3, T4, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3, T4>(this CombinedResult<SuiteRunFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SuiteRunFactory, T2, T3, T4, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SuiteRunFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SuiteRunFactory, T3, T4, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SuiteRunFactory, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SuiteRunFactory, T4, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SuiteRunFactory, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SuiteRunFactory, InnerSuiteRunSuiteRunConfigurationFactory> WithSuiteRunConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SuiteRunFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteRunConfiguration(combinedResult.T5, subFactoryAction).T2);
}

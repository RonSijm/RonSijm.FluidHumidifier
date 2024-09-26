// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTCoreDeviceAdvisor;

public class SuiteDefinitionFactory(string resourceName = null, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition> factoryAction = null) : ResourceFactory<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition>(resourceName)
{

    internal InnerSuiteDefinitionSuiteDefinitionConfigurationFactory SuiteDefinitionConfigurationFactory { get; set; }

    protected override Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition Create()
    {
        var suiteDefinitionResult = CreateSuiteDefinition();
        factoryAction?.Invoke(suiteDefinitionResult);

        return suiteDefinitionResult;
    }

    private Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition CreateSuiteDefinition()
    {
        var suiteDefinitionResult = new Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition
        {
            GivenName = InputResourceName,
        };

        return suiteDefinitionResult;
    }
    public override void CreateChildren(Humidifier.IoTCoreDeviceAdvisor.SuiteDefinition result)
    {
        base.CreateChildren(result);

        result.SuiteDefinitionConfiguration ??= SuiteDefinitionConfigurationFactory?.Build();
    }

} // End Of Class

public static class SuiteDefinitionFactoryExtensions
{
    public static CombinedResult<SuiteDefinitionFactory, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration(this SuiteDefinitionFactory parentFactory, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null)
    {
        parentFactory.SuiteDefinitionConfigurationFactory = new InnerSuiteDefinitionSuiteDefinitionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SuiteDefinitionConfigurationFactory);
    }

    public static CombinedResult<SuiteDefinitionFactory, T1, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1>(this CombinedResult<SuiteDefinitionFactory, T1> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SuiteDefinitionFactory, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1>(this CombinedResult<T1, SuiteDefinitionFactory> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SuiteDefinitionFactory, T1, T2, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2>(this CombinedResult<SuiteDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SuiteDefinitionFactory, T2, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2>(this CombinedResult<T1, SuiteDefinitionFactory, T2> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SuiteDefinitionFactory, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2>(this CombinedResult<T1, T2, SuiteDefinitionFactory> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SuiteDefinitionFactory, T1, T2, T3, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3>(this CombinedResult<SuiteDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SuiteDefinitionFactory, T2, T3, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3>(this CombinedResult<T1, SuiteDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SuiteDefinitionFactory, T3, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SuiteDefinitionFactory, T3> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SuiteDefinitionFactory, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SuiteDefinitionFactory> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SuiteDefinitionFactory, T1, T2, T3, T4, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3, T4>(this CombinedResult<SuiteDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SuiteDefinitionFactory, T2, T3, T4, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SuiteDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SuiteDefinitionFactory, T3, T4, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SuiteDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SuiteDefinitionFactory, T4, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SuiteDefinitionFactory, T4> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SuiteDefinitionFactory, InnerSuiteDefinitionSuiteDefinitionConfigurationFactory> WithSuiteDefinitionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SuiteDefinitionFactory> combinedResult, Action<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuiteDefinitionConfiguration(combinedResult.T5, subFactoryAction));
}

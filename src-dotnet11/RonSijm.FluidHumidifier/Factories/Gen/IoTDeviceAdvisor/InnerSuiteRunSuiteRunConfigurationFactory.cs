// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTDeviceAdvisor;

public class InnerSuiteRunSuiteRunConfigurationFactory(Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration>
{

    internal InnerSuiteRunDeviceUnderTestFactory PrimaryDeviceFactory { get; set; }

    protected override Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration Create()
    {
        var suiteRunConfigurationResult = CreateSuiteRunConfiguration();
        factoryAction?.Invoke(suiteRunConfigurationResult);

        return suiteRunConfigurationResult;
    }

    private Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration CreateSuiteRunConfiguration()
    {
        var suiteRunConfigurationResult = new Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration();

        return suiteRunConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration result)
    {
        base.CreateChildren(result);

        result.PrimaryDevice ??= PrimaryDeviceFactory?.Build();
    }

} // End Of Class

public static class InnerSuiteRunSuiteRunConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice(this InnerSuiteRunSuiteRunConfigurationFactory parentFactory, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null)
    {
        parentFactory.PrimaryDeviceFactory = new InnerSuiteRunDeviceUnderTestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrimaryDeviceFactory);
    }

    public static CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1>(this CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1>(this CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2>(this CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2>(this CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2>(this CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2, T3, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3>(this CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2, T3, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3>(this CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory, T3, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3>(this CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2, T3, T4, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3, T4>(this CombinedResult<InnerSuiteRunSuiteRunConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2, T3, T4, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3, T4>(this CombinedResult<T1, InnerSuiteRunSuiteRunConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory, T3, T4, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSuiteRunSuiteRunConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory, T4, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSuiteRunSuiteRunConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSuiteRunSuiteRunConfigurationFactory, InnerSuiteRunDeviceUnderTestFactory> WithPrimaryDevice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSuiteRunSuiteRunConfigurationFactory> combinedResult, Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryDevice(combinedResult.T5, subFactoryAction).T2);
}

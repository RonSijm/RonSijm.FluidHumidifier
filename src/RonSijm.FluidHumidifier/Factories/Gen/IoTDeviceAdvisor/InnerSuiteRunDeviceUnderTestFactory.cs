// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTDeviceAdvisor;

public class InnerSuiteRunDeviceUnderTestFactory(Action<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest> factoryAction = null) : SubResourceFactory<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest>
{

    protected override Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest Create()
    {
        var deviceUnderTestResult = CreateDeviceUnderTest();
        factoryAction?.Invoke(deviceUnderTestResult);

        return deviceUnderTestResult;
    }

    private Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest CreateDeviceUnderTest()
    {
        var deviceUnderTestResult = new Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest();

        return deviceUnderTestResult;
    }

} // End Of Class

public static class InnerSuiteRunDeviceUnderTestFactoryExtensions
{
}

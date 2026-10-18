// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseM2ManagedActionPropertiesFactory(Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties>
{

    protected override Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties Create()
    {
        var m2ManagedActionPropertiesResult = CreateM2ManagedActionProperties();
        factoryAction?.Invoke(m2ManagedActionPropertiesResult);

        return m2ManagedActionPropertiesResult;
    }

    private Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties CreateM2ManagedActionProperties()
    {
        var m2ManagedActionPropertiesResult = new Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties();

        return m2ManagedActionPropertiesResult;
    }

} // End Of Class

public static class InnerTestCaseM2ManagedActionPropertiesFactoryExtensions
{
}

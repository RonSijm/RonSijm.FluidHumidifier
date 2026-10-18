// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseM2NonManagedApplicationActionFactory(Action<Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction>
{

    protected override Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction Create()
    {
        var m2NonManagedApplicationActionResult = CreateM2NonManagedApplicationAction();
        factoryAction?.Invoke(m2NonManagedApplicationActionResult);

        return m2NonManagedApplicationActionResult;
    }

    private Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction CreateM2NonManagedApplicationAction()
    {
        var m2NonManagedApplicationActionResult = new Humidifier.AppTest.TestCaseTypes.M2NonManagedApplicationAction();

        return m2NonManagedApplicationActionResult;
    }

} // End Of Class

public static class InnerTestCaseM2NonManagedApplicationActionFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseScriptFactory(Action<Humidifier.AppTest.TestCaseTypes.Script> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.Script>
{

    protected override Humidifier.AppTest.TestCaseTypes.Script Create()
    {
        var scriptResult = CreateScript();
        factoryAction?.Invoke(scriptResult);

        return scriptResult;
    }

    private Humidifier.AppTest.TestCaseTypes.Script CreateScript()
    {
        var scriptResult = new Humidifier.AppTest.TestCaseTypes.Script();

        return scriptResult;
    }

} // End Of Class

public static class InnerTestCaseScriptFactoryExtensions
{
}

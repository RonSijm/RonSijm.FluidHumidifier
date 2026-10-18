// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseMainframeActionPropertiesFactory(Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties>
{

    protected override Humidifier.AppTest.TestCaseTypes.MainframeActionProperties Create()
    {
        var mainframeActionPropertiesResult = CreateMainframeActionProperties();
        factoryAction?.Invoke(mainframeActionPropertiesResult);

        return mainframeActionPropertiesResult;
    }

    private Humidifier.AppTest.TestCaseTypes.MainframeActionProperties CreateMainframeActionProperties()
    {
        var mainframeActionPropertiesResult = new Humidifier.AppTest.TestCaseTypes.MainframeActionProperties();

        return mainframeActionPropertiesResult;
    }

} // End Of Class

public static class InnerTestCaseMainframeActionPropertiesFactoryExtensions
{
}

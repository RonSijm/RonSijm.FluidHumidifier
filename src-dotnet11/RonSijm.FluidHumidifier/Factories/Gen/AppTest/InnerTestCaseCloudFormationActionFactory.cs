// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseCloudFormationActionFactory(Action<Humidifier.AppTest.TestCaseTypes.CloudFormationAction> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.CloudFormationAction>
{

    protected override Humidifier.AppTest.TestCaseTypes.CloudFormationAction Create()
    {
        var cloudFormationActionResult = CreateCloudFormationAction();
        factoryAction?.Invoke(cloudFormationActionResult);

        return cloudFormationActionResult;
    }

    private Humidifier.AppTest.TestCaseTypes.CloudFormationAction CreateCloudFormationAction()
    {
        var cloudFormationActionResult = new Humidifier.AppTest.TestCaseTypes.CloudFormationAction();

        return cloudFormationActionResult;
    }

} // End Of Class

public static class InnerTestCaseCloudFormationActionFactoryExtensions
{
}

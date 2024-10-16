// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseBatchFactory(Action<Humidifier.AppTest.TestCaseTypes.Batch> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.Batch>
{

    protected override Humidifier.AppTest.TestCaseTypes.Batch Create()
    {
        var batchResult = CreateBatch();
        factoryAction?.Invoke(batchResult);

        return batchResult;
    }

    private Humidifier.AppTest.TestCaseTypes.Batch CreateBatch()
    {
        var batchResult = new Humidifier.AppTest.TestCaseTypes.Batch();

        return batchResult;
    }

} // End Of Class

public static class InnerTestCaseBatchFactoryExtensions
{
}

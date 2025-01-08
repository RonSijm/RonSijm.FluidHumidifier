// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableWarmThroughputFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput Create()
    {
        var warmThroughputResult = CreateWarmThroughput();
        factoryAction?.Invoke(warmThroughputResult);

        return warmThroughputResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput CreateWarmThroughput()
    {
        var warmThroughputResult = new Humidifier.DynamoDB.GlobalTableTypes.WarmThroughput();

        return warmThroughputResult;
    }

} // End Of Class

public static class InnerGlobalTableWarmThroughputFactoryExtensions
{
}

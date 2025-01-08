// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableWarmThroughputFactory(Action<Humidifier.DynamoDB.TableTypes.WarmThroughput> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.WarmThroughput>
{

    protected override Humidifier.DynamoDB.TableTypes.WarmThroughput Create()
    {
        var warmThroughputResult = CreateWarmThroughput();
        factoryAction?.Invoke(warmThroughputResult);

        return warmThroughputResult;
    }

    private Humidifier.DynamoDB.TableTypes.WarmThroughput CreateWarmThroughput()
    {
        var warmThroughputResult = new Humidifier.DynamoDB.TableTypes.WarmThroughput();

        return warmThroughputResult;
    }

} // End Of Class

public static class InnerTableWarmThroughputFactoryExtensions
{
}

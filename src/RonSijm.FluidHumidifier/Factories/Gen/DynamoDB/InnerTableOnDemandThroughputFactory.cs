// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableOnDemandThroughputFactory(Action<Humidifier.DynamoDB.TableTypes.OnDemandThroughput> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.OnDemandThroughput>
{

    protected override Humidifier.DynamoDB.TableTypes.OnDemandThroughput Create()
    {
        var onDemandThroughputResult = CreateOnDemandThroughput();
        factoryAction?.Invoke(onDemandThroughputResult);

        return onDemandThroughputResult;
    }

    private Humidifier.DynamoDB.TableTypes.OnDemandThroughput CreateOnDemandThroughput()
    {
        var onDemandThroughputResult = new Humidifier.DynamoDB.TableTypes.OnDemandThroughput();

        return onDemandThroughputResult;
    }

} // End Of Class

public static class InnerTableOnDemandThroughputFactoryExtensions
{
}

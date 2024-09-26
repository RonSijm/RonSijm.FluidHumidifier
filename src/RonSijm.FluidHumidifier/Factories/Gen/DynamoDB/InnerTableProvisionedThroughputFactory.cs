// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableProvisionedThroughputFactory(Action<Humidifier.DynamoDB.TableTypes.ProvisionedThroughput> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.ProvisionedThroughput>
{

    protected override Humidifier.DynamoDB.TableTypes.ProvisionedThroughput Create()
    {
        var provisionedThroughputResult = CreateProvisionedThroughput();
        factoryAction?.Invoke(provisionedThroughputResult);

        return provisionedThroughputResult;
    }

    private Humidifier.DynamoDB.TableTypes.ProvisionedThroughput CreateProvisionedThroughput()
    {
        var provisionedThroughputResult = new Humidifier.DynamoDB.TableTypes.ProvisionedThroughput();

        return provisionedThroughputResult;
    }

} // End Of Class

public static class InnerTableProvisionedThroughputFactoryExtensions
{
}

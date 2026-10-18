// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerLogListFactory(Action<Humidifier.AmazonMQ.BrokerTypes.LogList> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.LogList>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.LogList Create()
    {
        var logListResult = CreateLogList();
        factoryAction?.Invoke(logListResult);

        return logListResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.LogList CreateLogList()
    {
        var logListResult = new Humidifier.AmazonMQ.BrokerTypes.LogList();

        return logListResult;
    }

} // End Of Class

public static class InnerBrokerLogListFactoryExtensions
{
}

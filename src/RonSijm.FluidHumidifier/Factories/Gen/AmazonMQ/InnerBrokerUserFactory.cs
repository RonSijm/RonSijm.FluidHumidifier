// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerUserFactory(Action<Humidifier.AmazonMQ.BrokerTypes.User> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.User>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.User CreateUser()
    {
        var userResult = new Humidifier.AmazonMQ.BrokerTypes.User();

        return userResult;
    }

} // End Of Class

public static class InnerBrokerUserFactoryExtensions
{
}

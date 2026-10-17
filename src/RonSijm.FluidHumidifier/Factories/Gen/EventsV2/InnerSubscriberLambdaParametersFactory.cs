// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberLambdaParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.LambdaParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.LambdaParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.LambdaParameters Create()
    {
        var lambdaParametersResult = CreateLambdaParameters();
        factoryAction?.Invoke(lambdaParametersResult);

        return lambdaParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.LambdaParameters CreateLambdaParameters()
    {
        var lambdaParametersResult = new Humidifier.EventsV2.SubscriberTypes.LambdaParameters();

        return lambdaParametersResult;
    }

} // End Of Class

public static class InnerSubscriberLambdaParametersFactoryExtensions
{
}

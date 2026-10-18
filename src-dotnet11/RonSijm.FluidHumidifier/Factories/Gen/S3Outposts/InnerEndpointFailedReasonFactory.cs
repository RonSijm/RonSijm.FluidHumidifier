// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class InnerEndpointFailedReasonFactory(Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> factoryAction = null) : SubResourceFactory<Humidifier.S3Outposts.EndpointTypes.FailedReason>
{

    protected override Humidifier.S3Outposts.EndpointTypes.FailedReason Create()
    {
        var failedReasonResult = CreateFailedReason();
        factoryAction?.Invoke(failedReasonResult);

        return failedReasonResult;
    }

    private Humidifier.S3Outposts.EndpointTypes.FailedReason CreateFailedReason()
    {
        var failedReasonResult = new Humidifier.S3Outposts.EndpointTypes.FailedReason();

        return failedReasonResult;
    }

} // End Of Class

public static class InnerEndpointFailedReasonFactoryExtensions
{
}

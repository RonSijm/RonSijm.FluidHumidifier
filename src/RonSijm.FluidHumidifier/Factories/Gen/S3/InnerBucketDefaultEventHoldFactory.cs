// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketDefaultEventHoldFactory(Action<Humidifier.S3.BucketTypes.DefaultEventHold> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.DefaultEventHold>
{

    protected override Humidifier.S3.BucketTypes.DefaultEventHold Create()
    {
        var defaultEventHoldResult = CreateDefaultEventHold();
        factoryAction?.Invoke(defaultEventHoldResult);

        return defaultEventHoldResult;
    }

    private Humidifier.S3.BucketTypes.DefaultEventHold CreateDefaultEventHold()
    {
        var defaultEventHoldResult = new Humidifier.S3.BucketTypes.DefaultEventHold();

        return defaultEventHoldResult;
    }

} // End Of Class

public static class InnerBucketDefaultEventHoldFactoryExtensions
{
}

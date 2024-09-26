// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessInstanceKinesisDataFirehoseFactory(Action<Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose>
{

    protected override Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose Create()
    {
        var kinesisDataFirehoseResult = CreateKinesisDataFirehose();
        factoryAction?.Invoke(kinesisDataFirehoseResult);

        return kinesisDataFirehoseResult;
    }

    private Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose CreateKinesisDataFirehose()
    {
        var kinesisDataFirehoseResult = new Humidifier.EC2.VerifiedAccessInstanceTypes.KinesisDataFirehose();

        return kinesisDataFirehoseResult;
    }

} // End Of Class

public static class InnerVerifiedAccessInstanceKinesisDataFirehoseFactoryExtensions
{
}

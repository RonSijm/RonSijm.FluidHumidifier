// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamVpcConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamVpcConfigurationFactoryExtensions
{
}

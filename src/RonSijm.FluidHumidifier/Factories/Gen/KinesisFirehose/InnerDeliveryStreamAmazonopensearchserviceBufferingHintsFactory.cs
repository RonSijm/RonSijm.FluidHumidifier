// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamAmazonopensearchserviceBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceBufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceBufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceBufferingHints Create()
    {
        var amazonopensearchserviceBufferingHintsResult = CreateAmazonopensearchserviceBufferingHints();
        factoryAction?.Invoke(amazonopensearchserviceBufferingHintsResult);

        return amazonopensearchserviceBufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceBufferingHints CreateAmazonopensearchserviceBufferingHints()
    {
        var amazonopensearchserviceBufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.AmazonopensearchserviceBufferingHints();

        return amazonopensearchserviceBufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamAmazonopensearchserviceBufferingHintsFactoryExtensions
{
}

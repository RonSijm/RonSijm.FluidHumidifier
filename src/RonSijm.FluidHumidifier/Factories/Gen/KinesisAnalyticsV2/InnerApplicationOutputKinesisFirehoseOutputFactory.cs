// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationOutputKinesisFirehoseOutputFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput Create()
    {
        var kinesisFirehoseOutputResult = CreateKinesisFirehoseOutput();
        factoryAction?.Invoke(kinesisFirehoseOutputResult);

        return kinesisFirehoseOutputResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput CreateKinesisFirehoseOutput()
    {
        var kinesisFirehoseOutputResult = new Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisFirehoseOutput();

        return kinesisFirehoseOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputKinesisFirehoseOutputFactoryExtensions
{
}

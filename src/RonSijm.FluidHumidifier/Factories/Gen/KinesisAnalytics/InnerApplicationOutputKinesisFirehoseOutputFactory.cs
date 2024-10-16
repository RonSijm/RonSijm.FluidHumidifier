// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationOutputKinesisFirehoseOutputFactory(Action<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput>
{

    protected override Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput Create()
    {
        var kinesisFirehoseOutputResult = CreateKinesisFirehoseOutput();
        factoryAction?.Invoke(kinesisFirehoseOutputResult);

        return kinesisFirehoseOutputResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput CreateKinesisFirehoseOutput()
    {
        var kinesisFirehoseOutputResult = new Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisFirehoseOutput();

        return kinesisFirehoseOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputKinesisFirehoseOutputFactoryExtensions
{
}

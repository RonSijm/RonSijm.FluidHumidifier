// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationKinesisFirehoseInputFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.KinesisFirehoseInput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.KinesisFirehoseInput>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.KinesisFirehoseInput Create()
    {
        var kinesisFirehoseInputResult = CreateKinesisFirehoseInput();
        factoryAction?.Invoke(kinesisFirehoseInputResult);

        return kinesisFirehoseInputResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.KinesisFirehoseInput CreateKinesisFirehoseInput()
    {
        var kinesisFirehoseInputResult = new Humidifier.KinesisAnalytics.ApplicationTypes.KinesisFirehoseInput();

        return kinesisFirehoseInputResult;
    }

} // End Of Class

public static class InnerApplicationKinesisFirehoseInputFactoryExtensions
{
}

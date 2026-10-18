// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationKinesisStreamsInputFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.KinesisStreamsInput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.KinesisStreamsInput>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.KinesisStreamsInput Create()
    {
        var kinesisStreamsInputResult = CreateKinesisStreamsInput();
        factoryAction?.Invoke(kinesisStreamsInputResult);

        return kinesisStreamsInputResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.KinesisStreamsInput CreateKinesisStreamsInput()
    {
        var kinesisStreamsInputResult = new Humidifier.KinesisAnalytics.ApplicationTypes.KinesisStreamsInput();

        return kinesisStreamsInputResult;
    }

} // End Of Class

public static class InnerApplicationKinesisStreamsInputFactoryExtensions
{
}

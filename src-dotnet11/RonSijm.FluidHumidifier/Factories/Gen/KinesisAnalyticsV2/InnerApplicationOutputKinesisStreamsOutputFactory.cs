// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationOutputKinesisStreamsOutputFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput Create()
    {
        var kinesisStreamsOutputResult = CreateKinesisStreamsOutput();
        factoryAction?.Invoke(kinesisStreamsOutputResult);

        return kinesisStreamsOutputResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput CreateKinesisStreamsOutput()
    {
        var kinesisStreamsOutputResult = new Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.KinesisStreamsOutput();

        return kinesisStreamsOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputKinesisStreamsOutputFactoryExtensions
{
}

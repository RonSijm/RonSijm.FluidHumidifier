// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationOutputKinesisStreamsOutputFactory(Action<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput>
{

    protected override Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput Create()
    {
        var kinesisStreamsOutputResult = CreateKinesisStreamsOutput();
        factoryAction?.Invoke(kinesisStreamsOutputResult);

        return kinesisStreamsOutputResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput CreateKinesisStreamsOutput()
    {
        var kinesisStreamsOutputResult = new Humidifier.KinesisAnalytics.ApplicationOutputTypes.KinesisStreamsOutput();

        return kinesisStreamsOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputKinesisStreamsOutputFactoryExtensions
{
}

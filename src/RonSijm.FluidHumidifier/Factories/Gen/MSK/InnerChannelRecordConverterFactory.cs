// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelRecordConverterFactory(Action<Humidifier.MSK.ChannelTypes.RecordConverter> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.RecordConverter>
{

    protected override Humidifier.MSK.ChannelTypes.RecordConverter Create()
    {
        var recordConverterResult = CreateRecordConverter();
        factoryAction?.Invoke(recordConverterResult);

        return recordConverterResult;
    }

    private Humidifier.MSK.ChannelTypes.RecordConverter CreateRecordConverter()
    {
        var recordConverterResult = new Humidifier.MSK.ChannelTypes.RecordConverter();

        return recordConverterResult;
    }

} // End Of Class

public static class InnerChannelRecordConverterFactoryExtensions
{
}

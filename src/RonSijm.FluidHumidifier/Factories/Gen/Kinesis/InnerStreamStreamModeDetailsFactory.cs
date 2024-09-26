// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerStreamStreamModeDetailsFactory(Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.StreamTypes.StreamModeDetails>
{

    protected override Humidifier.Kinesis.StreamTypes.StreamModeDetails Create()
    {
        var streamModeDetailsResult = CreateStreamModeDetails();
        factoryAction?.Invoke(streamModeDetailsResult);

        return streamModeDetailsResult;
    }

    private Humidifier.Kinesis.StreamTypes.StreamModeDetails CreateStreamModeDetails()
    {
        var streamModeDetailsResult = new Humidifier.Kinesis.StreamTypes.StreamModeDetails();

        return streamModeDetailsResult;
    }

} // End Of Class

public static class InnerStreamStreamModeDetailsFactoryExtensions
{
}

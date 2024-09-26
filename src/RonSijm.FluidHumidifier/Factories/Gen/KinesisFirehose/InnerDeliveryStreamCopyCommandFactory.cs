// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamCopyCommandFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.CopyCommand> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.CopyCommand>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.CopyCommand Create()
    {
        var copyCommandResult = CreateCopyCommand();
        factoryAction?.Invoke(copyCommandResult);

        return copyCommandResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.CopyCommand CreateCopyCommand()
    {
        var copyCommandResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.CopyCommand();

        return copyCommandResult;
    }

} // End Of Class

public static class InnerDeliveryStreamCopyCommandFactoryExtensions
{
}

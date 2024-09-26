// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskTransferredFactory(Action<Humidifier.DataSync.TaskTypes.Transferred> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Transferred>
{

    protected override Humidifier.DataSync.TaskTypes.Transferred Create()
    {
        var transferredResult = CreateTransferred();
        factoryAction?.Invoke(transferredResult);

        return transferredResult;
    }

    private Humidifier.DataSync.TaskTypes.Transferred CreateTransferred()
    {
        var transferredResult = new Humidifier.DataSync.TaskTypes.Transferred();

        return transferredResult;
    }

} // End Of Class

public static class InnerTaskTransferredFactoryExtensions
{
}

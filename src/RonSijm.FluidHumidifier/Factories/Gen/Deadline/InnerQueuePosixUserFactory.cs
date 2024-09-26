// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueuePosixUserFactory(Action<Humidifier.Deadline.QueueTypes.PosixUser> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.PosixUser>
{

    protected override Humidifier.Deadline.QueueTypes.PosixUser Create()
    {
        var posixUserResult = CreatePosixUser();
        factoryAction?.Invoke(posixUserResult);

        return posixUserResult;
    }

    private Humidifier.Deadline.QueueTypes.PosixUser CreatePosixUser()
    {
        var posixUserResult = new Humidifier.Deadline.QueueTypes.PosixUser();

        return posixUserResult;
    }

} // End Of Class

public static class InnerQueuePosixUserFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueueWindowsUserFactory(Action<Humidifier.Deadline.QueueTypes.WindowsUser> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.WindowsUser>
{

    protected override Humidifier.Deadline.QueueTypes.WindowsUser Create()
    {
        var windowsUserResult = CreateWindowsUser();
        factoryAction?.Invoke(windowsUserResult);

        return windowsUserResult;
    }

    private Humidifier.Deadline.QueueTypes.WindowsUser CreateWindowsUser()
    {
        var windowsUserResult = new Humidifier.Deadline.QueueTypes.WindowsUser();

        return windowsUserResult;
    }

} // End Of Class

public static class InnerQueueWindowsUserFactoryExtensions
{
}

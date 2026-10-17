// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmWallClockWindowFactory(Action<Humidifier.CloudWatch.AlarmTypes.WallClockWindow> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.WallClockWindow>
{

    protected override Humidifier.CloudWatch.AlarmTypes.WallClockWindow Create()
    {
        var wallClockWindowResult = CreateWallClockWindow();
        factoryAction?.Invoke(wallClockWindowResult);

        return wallClockWindowResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.WallClockWindow CreateWallClockWindow()
    {
        var wallClockWindowResult = new Humidifier.CloudWatch.AlarmTypes.WallClockWindow();

        return wallClockWindowResult;
    }

} // End Of Class

public static class InnerAlarmWallClockWindowFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerTaskDurationSinceLastAccessFactory(Action<Humidifier.FSx.TaskTypes.DurationSinceLastAccess> factoryAction = null) : SubResourceFactory<Humidifier.FSx.TaskTypes.DurationSinceLastAccess>
{

    protected override Humidifier.FSx.TaskTypes.DurationSinceLastAccess Create()
    {
        var durationSinceLastAccessResult = CreateDurationSinceLastAccess();
        factoryAction?.Invoke(durationSinceLastAccessResult);

        return durationSinceLastAccessResult;
    }

    private Humidifier.FSx.TaskTypes.DurationSinceLastAccess CreateDurationSinceLastAccess()
    {
        var durationSinceLastAccessResult = new Humidifier.FSx.TaskTypes.DurationSinceLastAccess();

        return durationSinceLastAccessResult;
    }

} // End Of Class

public static class InnerTaskDurationSinceLastAccessFactoryExtensions
{
}

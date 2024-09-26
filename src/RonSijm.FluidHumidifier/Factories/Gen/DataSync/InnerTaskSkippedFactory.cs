// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskSkippedFactory(Action<Humidifier.DataSync.TaskTypes.Skipped> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Skipped>
{

    protected override Humidifier.DataSync.TaskTypes.Skipped Create()
    {
        var skippedResult = CreateSkipped();
        factoryAction?.Invoke(skippedResult);

        return skippedResult;
    }

    private Humidifier.DataSync.TaskTypes.Skipped CreateSkipped()
    {
        var skippedResult = new Humidifier.DataSync.TaskTypes.Skipped();

        return skippedResult;
    }

} // End Of Class

public static class InnerTaskSkippedFactoryExtensions
{
}

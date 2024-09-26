// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskDeletedFactory(Action<Humidifier.DataSync.TaskTypes.Deleted> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Deleted>
{

    protected override Humidifier.DataSync.TaskTypes.Deleted Create()
    {
        var deletedResult = CreateDeleted();
        factoryAction?.Invoke(deletedResult);

        return deletedResult;
    }

    private Humidifier.DataSync.TaskTypes.Deleted CreateDeleted()
    {
        var deletedResult = new Humidifier.DataSync.TaskTypes.Deleted();

        return deletedResult;
    }

} // End Of Class

public static class InnerTaskDeletedFactoryExtensions
{
}

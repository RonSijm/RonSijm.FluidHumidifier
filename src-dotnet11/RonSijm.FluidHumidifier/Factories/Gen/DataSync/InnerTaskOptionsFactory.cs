// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskOptionsFactory(Action<Humidifier.DataSync.TaskTypes.Options> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Options>
{

    protected override Humidifier.DataSync.TaskTypes.Options Create()
    {
        var optionsResult = CreateOptions();
        factoryAction?.Invoke(optionsResult);

        return optionsResult;
    }

    private Humidifier.DataSync.TaskTypes.Options CreateOptions()
    {
        var optionsResult = new Humidifier.DataSync.TaskTypes.Options();

        return optionsResult;
    }

} // End Of Class

public static class InnerTaskOptionsFactoryExtensions
{
}

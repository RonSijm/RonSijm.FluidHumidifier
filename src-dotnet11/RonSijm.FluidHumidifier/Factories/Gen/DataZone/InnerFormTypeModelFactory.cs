// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerFormTypeModelFactory(Action<Humidifier.DataZone.FormTypeTypes.Model> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.FormTypeTypes.Model>
{

    protected override Humidifier.DataZone.FormTypeTypes.Model Create()
    {
        var modelResult = CreateModel();
        factoryAction?.Invoke(modelResult);

        return modelResult;
    }

    private Humidifier.DataZone.FormTypeTypes.Model CreateModel()
    {
        var modelResult = new Humidifier.DataZone.FormTypeTypes.Model();

        return modelResult;
    }

} // End Of Class

public static class InnerFormTypeModelFactoryExtensions
{
}

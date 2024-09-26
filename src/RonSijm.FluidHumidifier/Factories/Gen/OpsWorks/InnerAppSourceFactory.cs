// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerAppSourceFactory(Action<Humidifier.OpsWorks.AppTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.AppTypes.Source>
{

    protected override Humidifier.OpsWorks.AppTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.OpsWorks.AppTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.OpsWorks.AppTypes.Source();

        return sourceResult;
    }

} // End Of Class

public static class InnerAppSourceFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerStackSourceFactory(Action<Humidifier.OpsWorks.StackTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.StackTypes.Source>
{

    protected override Humidifier.OpsWorks.StackTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.OpsWorks.StackTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.OpsWorks.StackTypes.Source();

        return sourceResult;
    }

} // End Of Class

public static class InnerStackSourceFactoryExtensions
{
}

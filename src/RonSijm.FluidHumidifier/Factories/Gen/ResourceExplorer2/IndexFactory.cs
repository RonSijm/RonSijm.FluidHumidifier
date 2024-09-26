// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceExplorer2;

public class IndexFactory(string resourceName = null, Action<Humidifier.ResourceExplorer2.Index> factoryAction = null) : ResourceFactory<Humidifier.ResourceExplorer2.Index>(resourceName)
{

    protected override Humidifier.ResourceExplorer2.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.ResourceExplorer2.Index CreateIndex()
    {
        var indexResult = new Humidifier.ResourceExplorer2.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }

} // End Of Class

public static class IndexFactoryExtensions
{
}

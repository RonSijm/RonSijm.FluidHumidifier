// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class IndexFactory(string resourceName = null, Action<Humidifier.IoT.Index> factoryAction = null) : ResourceFactory<Humidifier.IoT.Index>(resourceName)
{

    protected override Humidifier.IoT.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.IoT.Index CreateIndex()
    {
        var indexResult = new Humidifier.IoT.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }

} // End Of Class

public static class IndexFactoryExtensions
{
}

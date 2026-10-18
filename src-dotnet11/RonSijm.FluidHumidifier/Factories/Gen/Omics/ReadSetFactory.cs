// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class ReadSetFactory(string resourceName = null, Action<Humidifier.Omics.ReadSet> factoryAction = null) : ResourceFactory<Humidifier.Omics.ReadSet>(resourceName)
{

    protected override Humidifier.Omics.ReadSet Create()
    {
        var readSetResult = CreateReadSet();
        factoryAction?.Invoke(readSetResult);

        return readSetResult;
    }

    private Humidifier.Omics.ReadSet CreateReadSet()
    {
        var readSetResult = new Humidifier.Omics.ReadSet
        {
            GivenName = InputResourceName,
        };

        return readSetResult;
    }

} // End Of Class

public static class ReadSetFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class MultiRegionParameterGroupFactory(string resourceName = null, Action<Humidifier.MemoryDB.MultiRegionParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.MultiRegionParameterGroup>(resourceName)
{

    protected override Humidifier.MemoryDB.MultiRegionParameterGroup Create()
    {
        var multiRegionParameterGroupResult = CreateMultiRegionParameterGroup();
        factoryAction?.Invoke(multiRegionParameterGroupResult);

        return multiRegionParameterGroupResult;
    }

    private Humidifier.MemoryDB.MultiRegionParameterGroup CreateMultiRegionParameterGroup()
    {
        var multiRegionParameterGroupResult = new Humidifier.MemoryDB.MultiRegionParameterGroup
        {
            GivenName = InputResourceName,
        };

        return multiRegionParameterGroupResult;
    }

} // End Of Class

public static class MultiRegionParameterGroupFactoryExtensions
{
}

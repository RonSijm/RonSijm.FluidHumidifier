// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class ReservedNodeFactory(string resourceName = null, Action<Humidifier.MemoryDB.ReservedNode> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.ReservedNode>(resourceName)
{

    protected override Humidifier.MemoryDB.ReservedNode Create()
    {
        var reservedNodeResult = CreateReservedNode();
        factoryAction?.Invoke(reservedNodeResult);

        return reservedNodeResult;
    }

    private Humidifier.MemoryDB.ReservedNode CreateReservedNode()
    {
        var reservedNodeResult = new Humidifier.MemoryDB.ReservedNode
        {
            GivenName = InputResourceName,
        };

        return reservedNodeResult;
    }

} // End Of Class

public static class ReservedNodeFactoryExtensions
{
}

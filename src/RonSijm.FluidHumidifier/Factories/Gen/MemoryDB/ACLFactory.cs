// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class ACLFactory(string resourceName = null, Action<Humidifier.MemoryDB.ACL> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.ACL>(resourceName)
{

    protected override Humidifier.MemoryDB.ACL Create()
    {
        var aCLResult = CreateACL();
        factoryAction?.Invoke(aCLResult);

        return aCLResult;
    }

    private Humidifier.MemoryDB.ACL CreateACL()
    {
        var aCLResult = new Humidifier.MemoryDB.ACL
        {
            GivenName = InputResourceName,
        };

        return aCLResult;
    }

} // End Of Class

public static class ACLFactoryExtensions
{
}

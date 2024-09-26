// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class AccessorFactory(string resourceName = null, Action<Humidifier.ManagedBlockchain.Accessor> factoryAction = null) : ResourceFactory<Humidifier.ManagedBlockchain.Accessor>(resourceName)
{

    protected override Humidifier.ManagedBlockchain.Accessor Create()
    {
        var accessorResult = CreateAccessor();
        factoryAction?.Invoke(accessorResult);

        return accessorResult;
    }

    private Humidifier.ManagedBlockchain.Accessor CreateAccessor()
    {
        var accessorResult = new Humidifier.ManagedBlockchain.Accessor
        {
            GivenName = InputResourceName,
        };

        return accessorResult;
    }

} // End Of Class

public static class AccessorFactoryExtensions
{
}

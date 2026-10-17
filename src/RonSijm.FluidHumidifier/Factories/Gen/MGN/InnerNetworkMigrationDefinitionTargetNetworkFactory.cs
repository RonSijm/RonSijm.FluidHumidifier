// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerNetworkMigrationDefinitionTargetNetworkFactory(Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork> factoryAction = null) : SubResourceFactory<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork>
{

    protected override Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork Create()
    {
        var targetNetworkResult = CreateTargetNetwork();
        factoryAction?.Invoke(targetNetworkResult);

        return targetNetworkResult;
    }

    private Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork CreateTargetNetwork()
    {
        var targetNetworkResult = new Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork();

        return targetNetworkResult;
    }

} // End Of Class

public static class InnerNetworkMigrationDefinitionTargetNetworkFactoryExtensions
{
}

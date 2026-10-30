// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableDatabricksDeltaSharingConnectionFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection Create()
    {
        var databricksDeltaSharingConnectionResult = CreateDatabricksDeltaSharingConnection();
        factoryAction?.Invoke(databricksDeltaSharingConnectionResult);

        return databricksDeltaSharingConnectionResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection CreateDatabricksDeltaSharingConnection()
    {
        var databricksDeltaSharingConnectionResult = new Humidifier.CleanRooms.ConfiguredTableTypes.DatabricksDeltaSharingConnection();

        return databricksDeltaSharingConnectionResult;
    }

} // End Of Class

public static class InnerConfiguredTableDatabricksDeltaSharingConnectionFactoryExtensions
{
}

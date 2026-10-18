// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserPersistentConnectionConfigFactory(Action<Humidifier.Connect.UserTypes.PersistentConnectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.PersistentConnectionConfig>
{

    protected override Humidifier.Connect.UserTypes.PersistentConnectionConfig Create()
    {
        var persistentConnectionConfigResult = CreatePersistentConnectionConfig();
        factoryAction?.Invoke(persistentConnectionConfigResult);

        return persistentConnectionConfigResult;
    }

    private Humidifier.Connect.UserTypes.PersistentConnectionConfig CreatePersistentConnectionConfig()
    {
        var persistentConnectionConfigResult = new Humidifier.Connect.UserTypes.PersistentConnectionConfig();

        return persistentConnectionConfigResult;
    }

} // End Of Class

public static class InnerUserPersistentConnectionConfigFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class EntityFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.Entity> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.Entity>(resourceName)
{

    protected override Humidifier.IoTTwinMaker.Entity Create()
    {
        var entityResult = CreateEntity();
        factoryAction?.Invoke(entityResult);

        return entityResult;
    }

    private Humidifier.IoTTwinMaker.Entity CreateEntity()
    {
        var entityResult = new Humidifier.IoTTwinMaker.Entity
        {
            GivenName = InputResourceName,
        };

        return entityResult;
    }

} // End Of Class

public static class EntityFactoryExtensions
{
}

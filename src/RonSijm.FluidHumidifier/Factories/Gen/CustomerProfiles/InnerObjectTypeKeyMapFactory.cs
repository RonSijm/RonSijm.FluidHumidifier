// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerObjectTypeKeyMapFactory(Action<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap>
{

    protected override Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap Create()
    {
        var keyMapResult = CreateKeyMap();
        factoryAction?.Invoke(keyMapResult);

        return keyMapResult;
    }

    private Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap CreateKeyMap()
    {
        var keyMapResult = new Humidifier.CustomerProfiles.ObjectTypeTypes.KeyMap();

        return keyMapResult;
    }

} // End Of Class

public static class InnerObjectTypeKeyMapFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class ProtectionGroupFactory(string resourceName = null, Action<Humidifier.Shield.ProtectionGroup> factoryAction = null) : ResourceFactory<Humidifier.Shield.ProtectionGroup>(resourceName)
{

    protected override Humidifier.Shield.ProtectionGroup Create()
    {
        var protectionGroupResult = CreateProtectionGroup();
        factoryAction?.Invoke(protectionGroupResult);

        return protectionGroupResult;
    }

    private Humidifier.Shield.ProtectionGroup CreateProtectionGroup()
    {
        var protectionGroupResult = new Humidifier.Shield.ProtectionGroup
        {
            GivenName = InputResourceName,
        };

        return protectionGroupResult;
    }

} // End Of Class

public static class ProtectionGroupFactoryExtensions
{
}

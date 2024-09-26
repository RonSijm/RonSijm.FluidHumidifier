// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class GroupProfileFactory(string resourceName = null, Action<Humidifier.DataZone.GroupProfile> factoryAction = null) : ResourceFactory<Humidifier.DataZone.GroupProfile>(resourceName)
{

    protected override Humidifier.DataZone.GroupProfile Create()
    {
        var groupProfileResult = CreateGroupProfile();
        factoryAction?.Invoke(groupProfileResult);

        return groupProfileResult;
    }

    private Humidifier.DataZone.GroupProfile CreateGroupProfile()
    {
        var groupProfileResult = new Humidifier.DataZone.GroupProfile
        {
            GivenName = InputResourceName,
        };

        return groupProfileResult;
    }

} // End Of Class

public static class GroupProfileFactoryExtensions
{
}

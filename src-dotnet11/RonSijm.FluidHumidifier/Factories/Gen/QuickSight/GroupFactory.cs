// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class GroupFactory(string resourceName = null, Action<Humidifier.QuickSight.Group> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Group>(resourceName)
{

    protected override Humidifier.QuickSight.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.QuickSight.Group CreateGroup()
    {
        var groupResult = new Humidifier.QuickSight.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }

} // End Of Class

public static class GroupFactoryExtensions
{
}

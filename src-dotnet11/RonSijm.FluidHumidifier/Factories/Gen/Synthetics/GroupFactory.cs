// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class GroupFactory(string resourceName = null, Action<Humidifier.Synthetics.Group> factoryAction = null) : ResourceFactory<Humidifier.Synthetics.Group>(resourceName)
{

    protected override Humidifier.Synthetics.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.Synthetics.Group CreateGroup()
    {
        var groupResult = new Humidifier.Synthetics.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }

} // End Of Class

public static class GroupFactoryExtensions
{
}

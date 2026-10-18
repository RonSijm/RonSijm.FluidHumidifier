// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class ConnectionGroupFactory(string resourceName = null, Action<Humidifier.CloudFront.ConnectionGroup> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.ConnectionGroup>(resourceName)
{

    protected override Humidifier.CloudFront.ConnectionGroup Create()
    {
        var connectionGroupResult = CreateConnectionGroup();
        factoryAction?.Invoke(connectionGroupResult);

        return connectionGroupResult;
    }

    private Humidifier.CloudFront.ConnectionGroup CreateConnectionGroup()
    {
        var connectionGroupResult = new Humidifier.CloudFront.ConnectionGroup
        {
            GivenName = InputResourceName,
        };

        return connectionGroupResult;
    }

} // End Of Class

public static class ConnectionGroupFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class ProtocolsListFactory(string resourceName = null, Action<Humidifier.FMS.ProtocolsList> factoryAction = null) : ResourceFactory<Humidifier.FMS.ProtocolsList>(resourceName)
{

    protected override Humidifier.FMS.ProtocolsList Create()
    {
        var protocolsListResult = CreateProtocolsList();
        factoryAction?.Invoke(protocolsListResult);

        return protocolsListResult;
    }

    private Humidifier.FMS.ProtocolsList CreateProtocolsList()
    {
        var protocolsListResult = new Humidifier.FMS.ProtocolsList
        {
            GivenName = InputResourceName,
        };

        return protocolsListResult;
    }

} // End Of Class

public static class ProtocolsListFactoryExtensions
{
}

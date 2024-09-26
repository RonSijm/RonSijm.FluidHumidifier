// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorAs2ConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.As2Config> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.As2Config>
{

    protected override Humidifier.Transfer.ConnectorTypes.As2Config Create()
    {
        var as2ConfigResult = CreateAs2Config();
        factoryAction?.Invoke(as2ConfigResult);

        return as2ConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.As2Config CreateAs2Config()
    {
        var as2ConfigResult = new Humidifier.Transfer.ConnectorTypes.As2Config();

        return as2ConfigResult;
    }

} // End Of Class

public static class InnerConnectorAs2ConfigFactoryExtensions
{
}

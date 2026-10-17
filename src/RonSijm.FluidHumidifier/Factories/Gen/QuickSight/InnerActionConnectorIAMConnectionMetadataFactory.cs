// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorIAMConnectionMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata Create()
    {
        var iAMConnectionMetadataResult = CreateIAMConnectionMetadata();
        factoryAction?.Invoke(iAMConnectionMetadataResult);

        return iAMConnectionMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata CreateIAMConnectionMetadata()
    {
        var iAMConnectionMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata();

        return iAMConnectionMetadataResult;
    }

} // End Of Class

public static class InnerActionConnectorIAMConnectionMetadataFactoryExtensions
{
}

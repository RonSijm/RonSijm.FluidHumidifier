// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorNoneConnectionMetadataFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata Create()
    {
        var noneConnectionMetadataResult = CreateNoneConnectionMetadata();
        factoryAction?.Invoke(noneConnectionMetadataResult);

        return noneConnectionMetadataResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata CreateNoneConnectionMetadata()
    {
        var noneConnectionMetadataResult = new Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata();

        return noneConnectionMetadataResult;
    }

} // End Of Class

public static class InnerActionConnectorNoneConnectionMetadataFactoryExtensions
{
}

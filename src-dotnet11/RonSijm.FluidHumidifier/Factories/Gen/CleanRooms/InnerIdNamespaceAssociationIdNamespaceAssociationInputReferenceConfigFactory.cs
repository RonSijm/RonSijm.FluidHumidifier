// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactory(Action<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig>
{

    protected override Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig Create()
    {
        var idNamespaceAssociationInputReferenceConfigResult = CreateIdNamespaceAssociationInputReferenceConfig();
        factoryAction?.Invoke(idNamespaceAssociationInputReferenceConfigResult);

        return idNamespaceAssociationInputReferenceConfigResult;
    }

    private Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig CreateIdNamespaceAssociationInputReferenceConfig()
    {
        var idNamespaceAssociationInputReferenceConfigResult = new Humidifier.CleanRooms.IdNamespaceAssociationTypes.IdNamespaceAssociationInputReferenceConfig();

        return idNamespaceAssociationInputReferenceConfigResult;
    }

} // End Of Class

public static class InnerIdNamespaceAssociationIdNamespaceAssociationInputReferenceConfigFactoryExtensions
{
}

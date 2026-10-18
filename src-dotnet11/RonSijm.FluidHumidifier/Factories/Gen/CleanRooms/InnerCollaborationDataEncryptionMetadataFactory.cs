// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationDataEncryptionMetadataFactory(Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata Create()
    {
        var dataEncryptionMetadataResult = CreateDataEncryptionMetadata();
        factoryAction?.Invoke(dataEncryptionMetadataResult);

        return dataEncryptionMetadataResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata CreateDataEncryptionMetadata()
    {
        var dataEncryptionMetadataResult = new Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata();

        return dataEncryptionMetadataResult;
    }

} // End Of Class

public static class InnerCollaborationDataEncryptionMetadataFactoryExtensions
{
}

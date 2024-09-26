// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterEncryptionAtRestFactory(Action<Humidifier.MSK.ClusterTypes.EncryptionAtRest> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.EncryptionAtRest>
{

    protected override Humidifier.MSK.ClusterTypes.EncryptionAtRest Create()
    {
        var encryptionAtRestResult = CreateEncryptionAtRest();
        factoryAction?.Invoke(encryptionAtRestResult);

        return encryptionAtRestResult;
    }

    private Humidifier.MSK.ClusterTypes.EncryptionAtRest CreateEncryptionAtRest()
    {
        var encryptionAtRestResult = new Humidifier.MSK.ClusterTypes.EncryptionAtRest();

        return encryptionAtRestResult;
    }

} // End Of Class

public static class InnerClusterEncryptionAtRestFactoryExtensions
{
}

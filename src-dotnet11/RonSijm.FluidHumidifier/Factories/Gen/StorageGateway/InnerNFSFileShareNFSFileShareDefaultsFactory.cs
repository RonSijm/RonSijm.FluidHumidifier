// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class InnerNFSFileShareNFSFileShareDefaultsFactory(Action<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults> factoryAction = null) : SubResourceFactory<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults>
{

    protected override Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults Create()
    {
        var nFSFileShareDefaultsResult = CreateNFSFileShareDefaults();
        factoryAction?.Invoke(nFSFileShareDefaultsResult);

        return nFSFileShareDefaultsResult;
    }

    private Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults CreateNFSFileShareDefaults()
    {
        var nFSFileShareDefaultsResult = new Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults();

        return nFSFileShareDefaultsResult;
    }

} // End Of Class

public static class InnerNFSFileShareNFSFileShareDefaultsFactoryExtensions
{
}

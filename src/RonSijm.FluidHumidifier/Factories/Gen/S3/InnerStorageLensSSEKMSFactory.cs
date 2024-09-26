// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensSSEKMSFactory(Action<Humidifier.S3.StorageLensTypes.SSEKMS> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.SSEKMS>
{

    protected override Humidifier.S3.StorageLensTypes.SSEKMS Create()
    {
        var sSEKMSResult = CreateSSEKMS();
        factoryAction?.Invoke(sSEKMSResult);

        return sSEKMSResult;
    }

    private Humidifier.S3.StorageLensTypes.SSEKMS CreateSSEKMS()
    {
        var sSEKMSResult = new Humidifier.S3.StorageLensTypes.SSEKMS();

        return sSEKMSResult;
    }

} // End Of Class

public static class InnerStorageLensSSEKMSFactoryExtensions
{
}

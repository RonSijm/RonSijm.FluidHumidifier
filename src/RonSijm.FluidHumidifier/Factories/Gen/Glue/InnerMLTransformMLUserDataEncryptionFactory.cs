// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerMLTransformMLUserDataEncryptionFactory(Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption>
{

    protected override Humidifier.Glue.MLTransformTypes.MLUserDataEncryption Create()
    {
        var mLUserDataEncryptionResult = CreateMLUserDataEncryption();
        factoryAction?.Invoke(mLUserDataEncryptionResult);

        return mLUserDataEncryptionResult;
    }

    private Humidifier.Glue.MLTransformTypes.MLUserDataEncryption CreateMLUserDataEncryption()
    {
        var mLUserDataEncryptionResult = new Humidifier.Glue.MLTransformTypes.MLUserDataEncryption();

        return mLUserDataEncryptionResult;
    }

} // End Of Class

public static class InnerMLTransformMLUserDataEncryptionFactoryExtensions
{
}

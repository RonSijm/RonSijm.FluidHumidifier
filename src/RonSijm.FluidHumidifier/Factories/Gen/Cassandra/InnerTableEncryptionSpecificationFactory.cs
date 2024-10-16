// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableEncryptionSpecificationFactory(Action<Humidifier.Cassandra.TableTypes.EncryptionSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.EncryptionSpecification>
{

    protected override Humidifier.Cassandra.TableTypes.EncryptionSpecification Create()
    {
        var encryptionSpecificationResult = CreateEncryptionSpecification();
        factoryAction?.Invoke(encryptionSpecificationResult);

        return encryptionSpecificationResult;
    }

    private Humidifier.Cassandra.TableTypes.EncryptionSpecification CreateEncryptionSpecification()
    {
        var encryptionSpecificationResult = new Humidifier.Cassandra.TableTypes.EncryptionSpecification();

        return encryptionSpecificationResult;
    }

} // End Of Class

public static class InnerTableEncryptionSpecificationFactoryExtensions
{
}

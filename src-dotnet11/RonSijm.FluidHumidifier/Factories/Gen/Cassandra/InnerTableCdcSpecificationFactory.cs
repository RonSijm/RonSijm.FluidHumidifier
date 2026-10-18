// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableCdcSpecificationFactory(Action<Humidifier.Cassandra.TableTypes.CdcSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.CdcSpecification>
{

    protected override Humidifier.Cassandra.TableTypes.CdcSpecification Create()
    {
        var cdcSpecificationResult = CreateCdcSpecification();
        factoryAction?.Invoke(cdcSpecificationResult);

        return cdcSpecificationResult;
    }

    private Humidifier.Cassandra.TableTypes.CdcSpecification CreateCdcSpecification()
    {
        var cdcSpecificationResult = new Humidifier.Cassandra.TableTypes.CdcSpecification();

        return cdcSpecificationResult;
    }

} // End Of Class

public static class InnerTableCdcSpecificationFactoryExtensions
{
}

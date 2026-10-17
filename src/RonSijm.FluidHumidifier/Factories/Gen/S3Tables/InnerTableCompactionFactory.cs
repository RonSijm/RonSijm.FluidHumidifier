// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableCompactionFactory(Action<Humidifier.S3Tables.TableTypes.Compaction> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.Compaction>
{

    protected override Humidifier.S3Tables.TableTypes.Compaction Create()
    {
        var compactionResult = CreateCompaction();
        factoryAction?.Invoke(compactionResult);

        return compactionResult;
    }

    private Humidifier.S3Tables.TableTypes.Compaction CreateCompaction()
    {
        var compactionResult = new Humidifier.S3Tables.TableTypes.Compaction();

        return compactionResult;
    }

} // End Of Class

public static class InnerTableCompactionFactoryExtensions
{
}

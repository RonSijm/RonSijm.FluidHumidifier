// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseSourceDatabaseMetadataFactory(Action<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata>
{

    protected override Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata Create()
    {
        var sourceDatabaseMetadataResult = CreateSourceDatabaseMetadata();
        factoryAction?.Invoke(sourceDatabaseMetadataResult);

        return sourceDatabaseMetadataResult;
    }

    private Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata CreateSourceDatabaseMetadata()
    {
        var sourceDatabaseMetadataResult = new Humidifier.AppTest.TestCaseTypes.SourceDatabaseMetadata();

        return sourceDatabaseMetadataResult;
    }

} // End Of Class

public static class InnerTestCaseSourceDatabaseMetadataFactoryExtensions
{
}

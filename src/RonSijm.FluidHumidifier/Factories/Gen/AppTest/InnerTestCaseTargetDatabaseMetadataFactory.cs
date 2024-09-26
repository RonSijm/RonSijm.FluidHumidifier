// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseTargetDatabaseMetadataFactory(Action<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata>
{

    protected override Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata Create()
    {
        var targetDatabaseMetadataResult = CreateTargetDatabaseMetadata();
        factoryAction?.Invoke(targetDatabaseMetadataResult);

        return targetDatabaseMetadataResult;
    }

    private Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata CreateTargetDatabaseMetadata()
    {
        var targetDatabaseMetadataResult = new Humidifier.AppTest.TestCaseTypes.TargetDatabaseMetadata();

        return targetDatabaseMetadataResult;
    }

} // End Of Class

public static class InnerTestCaseTargetDatabaseMetadataFactoryExtensions
{
}

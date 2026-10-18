// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerSourceApiAssociationSourceApiAssociationConfigFactory(Action<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig>
{

    protected override Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig Create()
    {
        var sourceApiAssociationConfigResult = CreateSourceApiAssociationConfig();
        factoryAction?.Invoke(sourceApiAssociationConfigResult);

        return sourceApiAssociationConfigResult;
    }

    private Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig CreateSourceApiAssociationConfig()
    {
        var sourceApiAssociationConfigResult = new Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig();

        return sourceApiAssociationConfigResult;
    }

} // End Of Class

public static class InnerSourceApiAssociationSourceApiAssociationConfigFactoryExtensions
{
}

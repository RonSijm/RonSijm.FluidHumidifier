// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetMetadataFactory(Action<Humidifier.DataBrew.DatasetTypes.Metadata> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.Metadata>
{

    protected override Humidifier.DataBrew.DatasetTypes.Metadata Create()
    {
        var metadataResult = CreateMetadata();
        factoryAction?.Invoke(metadataResult);

        return metadataResult;
    }

    private Humidifier.DataBrew.DatasetTypes.Metadata CreateMetadata()
    {
        var metadataResult = new Humidifier.DataBrew.DatasetTypes.Metadata();

        return metadataResult;
    }

} // End Of Class

public static class InnerDatasetMetadataFactoryExtensions
{
}

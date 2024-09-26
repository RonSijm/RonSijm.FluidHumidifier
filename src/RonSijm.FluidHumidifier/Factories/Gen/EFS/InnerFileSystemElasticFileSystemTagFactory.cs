// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerFileSystemElasticFileSystemTagFactory(Action<Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag> factoryAction = null) : SubResourceFactory<Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag>
{

    protected override Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag Create()
    {
        var elasticFileSystemTagResult = CreateElasticFileSystemTag();
        factoryAction?.Invoke(elasticFileSystemTagResult);

        return elasticFileSystemTagResult;
    }

    private Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag CreateElasticFileSystemTag()
    {
        var elasticFileSystemTagResult = new Humidifier.EFS.FileSystemTypes.ElasticFileSystemTag();

        return elasticFileSystemTagResult;
    }

} // End Of Class

public static class InnerFileSystemElasticFileSystemTagFactoryExtensions
{
}

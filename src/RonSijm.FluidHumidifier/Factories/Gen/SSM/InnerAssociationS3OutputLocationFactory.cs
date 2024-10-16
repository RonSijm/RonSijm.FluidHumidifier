// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerAssociationS3OutputLocationFactory(Action<Humidifier.SSM.AssociationTypes.S3OutputLocation> factoryAction = null) : SubResourceFactory<Humidifier.SSM.AssociationTypes.S3OutputLocation>
{

    protected override Humidifier.SSM.AssociationTypes.S3OutputLocation Create()
    {
        var s3OutputLocationResult = CreateS3OutputLocation();
        factoryAction?.Invoke(s3OutputLocationResult);

        return s3OutputLocationResult;
    }

    private Humidifier.SSM.AssociationTypes.S3OutputLocation CreateS3OutputLocation()
    {
        var s3OutputLocationResult = new Humidifier.SSM.AssociationTypes.S3OutputLocation();

        return s3OutputLocationResult;
    }

} // End Of Class

public static class InnerAssociationS3OutputLocationFactoryExtensions
{
}

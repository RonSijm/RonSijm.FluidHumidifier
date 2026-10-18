// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationVersionImageSourceFactory(Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource Create()
    {
        var imageSourceResult = CreateImageSource();
        factoryAction?.Invoke(imageSourceResult);

        return imageSourceResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource CreateImageSource()
    {
        var imageSourceResult = new Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageSource();

        return imageSourceResult;
    }

} // End Of Class

public static class InnerApplicationVersionImageSourceFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.AppStream.Application> factoryAction = null) : ResourceFactory<Humidifier.AppStream.Application>(resourceName)
{

    internal InnerApplicationS3LocationFactory IconS3LocationFactory { get; set; }

    protected override Humidifier.AppStream.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.AppStream.Application CreateApplication()
    {
        var applicationResult = new Humidifier.AppStream.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.AppStream.Application result)
    {
        base.CreateChildren(result);

        result.IconS3Location ??= IconS3LocationFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationS3LocationFactory> WithIconS3Location(this ApplicationFactory parentFactory, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.IconS3LocationFactory = new InnerApplicationS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IconS3LocationFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationS3LocationFactory> WithIconS3Location<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithIconS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationS3LocationFactory> WithIconS3Location<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithIconS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationS3LocationFactory> WithIconS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.AppStream.ApplicationTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIconS3Location(combinedResult.T5, subFactoryAction));
}

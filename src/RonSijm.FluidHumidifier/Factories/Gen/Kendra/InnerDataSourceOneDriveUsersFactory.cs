// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceOneDriveUsersFactory(Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.OneDriveUsers>
{

    internal InnerDataSourceS3PathFactory OneDriveUserS3PathFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.OneDriveUsers Create()
    {
        var oneDriveUsersResult = CreateOneDriveUsers();
        factoryAction?.Invoke(oneDriveUsersResult);

        return oneDriveUsersResult;
    }

    private Humidifier.Kendra.DataSourceTypes.OneDriveUsers CreateOneDriveUsers()
    {
        var oneDriveUsersResult = new Humidifier.Kendra.DataSourceTypes.OneDriveUsers();

        return oneDriveUsersResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.OneDriveUsers result)
    {
        base.CreateChildren(result);

        result.OneDriveUserS3Path ??= OneDriveUserS3PathFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceOneDriveUsersFactoryExtensions
{
    public static CombinedResult<InnerDataSourceOneDriveUsersFactory, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path(this InnerDataSourceOneDriveUsersFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null)
    {
        parentFactory.OneDriveUserS3PathFactory = new InnerDataSourceS3PathFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OneDriveUserS3PathFactory);
    }

    public static CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1>(this CombinedResult<InnerDataSourceOneDriveUsersFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1>(this CombinedResult<T1, InnerDataSourceOneDriveUsersFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2>(this CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2>(this CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2, T3, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3>(this CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2, T3, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory, T3, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOneDriveUsersFactory, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceOneDriveUsersFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2, T3, T4, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceOneDriveUsersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2, T3, T4, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceOneDriveUsersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory, T3, T4, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceOneDriveUsersFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOneDriveUsersFactory, T4, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceOneDriveUsersFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceOneDriveUsersFactory, InnerDataSourceS3PathFactory> WithOneDriveUserS3Path<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceOneDriveUsersFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.S3Path> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUserS3Path(combinedResult.T5, subFactoryAction));
}

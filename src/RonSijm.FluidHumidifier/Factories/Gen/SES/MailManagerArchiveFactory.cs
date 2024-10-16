// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerArchiveFactory(string resourceName = null, Action<Humidifier.SES.MailManagerArchive> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerArchive>(resourceName)
{

    internal InnerMailManagerArchiveArchiveRetentionFactory RetentionFactory { get; set; }

    protected override Humidifier.SES.MailManagerArchive Create()
    {
        var mailManagerArchiveResult = CreateMailManagerArchive();
        factoryAction?.Invoke(mailManagerArchiveResult);

        return mailManagerArchiveResult;
    }

    private Humidifier.SES.MailManagerArchive CreateMailManagerArchive()
    {
        var mailManagerArchiveResult = new Humidifier.SES.MailManagerArchive
        {
            GivenName = InputResourceName,
        };

        return mailManagerArchiveResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerArchive result)
    {
        base.CreateChildren(result);

        result.Retention ??= RetentionFactory?.Build();
    }

} // End Of Class

public static class MailManagerArchiveFactoryExtensions
{
    public static CombinedResult<MailManagerArchiveFactory, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention(this MailManagerArchiveFactory parentFactory, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null)
    {
        parentFactory.RetentionFactory = new InnerMailManagerArchiveArchiveRetentionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionFactory);
    }

    public static CombinedResult<MailManagerArchiveFactory, T1, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1>(this CombinedResult<MailManagerArchiveFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerArchiveFactory, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1>(this CombinedResult<T1, MailManagerArchiveFactory> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MailManagerArchiveFactory, T1, T2, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2>(this CombinedResult<MailManagerArchiveFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerArchiveFactory, T2, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2>(this CombinedResult<T1, MailManagerArchiveFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerArchiveFactory, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2>(this CombinedResult<T1, T2, MailManagerArchiveFactory> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MailManagerArchiveFactory, T1, T2, T3, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<MailManagerArchiveFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerArchiveFactory, T2, T3, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, MailManagerArchiveFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerArchiveFactory, T3, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, T2, MailManagerArchiveFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerArchiveFactory, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, T2, T3, MailManagerArchiveFactory> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MailManagerArchiveFactory, T1, T2, T3, T4, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<MailManagerArchiveFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerArchiveFactory, T2, T3, T4, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, MailManagerArchiveFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerArchiveFactory, T3, T4, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, MailManagerArchiveFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerArchiveFactory, T4, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MailManagerArchiveFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MailManagerArchiveFactory, InnerMailManagerArchiveArchiveRetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MailManagerArchiveFactory> combinedResult, Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T5, subFactoryAction));
}

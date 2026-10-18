// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerEmailIdentityFeedbackAttributesFactory(Action<Humidifier.SES.EmailIdentityTypes.FeedbackAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.EmailIdentityTypes.FeedbackAttributes>
{

    protected override Humidifier.SES.EmailIdentityTypes.FeedbackAttributes Create()
    {
        var feedbackAttributesResult = CreateFeedbackAttributes();
        factoryAction?.Invoke(feedbackAttributesResult);

        return feedbackAttributesResult;
    }

    private Humidifier.SES.EmailIdentityTypes.FeedbackAttributes CreateFeedbackAttributes()
    {
        var feedbackAttributesResult = new Humidifier.SES.EmailIdentityTypes.FeedbackAttributes();

        return feedbackAttributesResult;
    }

} // End Of Class

public static class InnerEmailIdentityFeedbackAttributesFactoryExtensions
{
}

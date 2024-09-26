using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.SNS;

public class SubscriptionNameDecorator : BaseTypeDecorator<Humidifier.SNS.Subscription>, IWantEnvironmentName, IWantResourceName
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 9000;

    public override void Decorate(Humidifier.SNS.Subscription target)
    {
        if (target.TopicArn is FFnImportValue topicImport)
        {
            var resource = topicImport.Result.Result.GivenName;
            target.GivenName = resource + "-Subscription";
        }

        //target.BucketName = target.BucketName.ToLower();
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
    public string ResourceName { get; set; }
}
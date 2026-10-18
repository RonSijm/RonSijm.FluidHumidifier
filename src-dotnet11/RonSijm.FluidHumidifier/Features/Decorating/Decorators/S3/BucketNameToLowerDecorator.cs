using Humidifier.S3;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.S3;

public class BucketNameToLowerDecorator : BaseTypeDecorator<Bucket>, IWantEnvironmentName, IWantStackName
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 9000;

    public override void Decorate(Bucket target)
    {
        if (target.BucketName is string name)
        {
            target.BucketName = name.ToLower();
        }
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}

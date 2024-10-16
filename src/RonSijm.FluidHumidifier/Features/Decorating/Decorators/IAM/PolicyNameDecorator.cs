using RonSijm.FluidHumidifier.Factories.IAM;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.IAM;
public class PolicyNameDecorator : BaseTypeDecorator<Policy>, IWantResourceName
{
    // Rank matter because you could decorate target.GivenName first if you want, to affect the name.
    // Post-fixing with -Policy is a common pattern. But with lower priority, to rename it in other decorators first.
    public override int Rank { get; set; } = 200;

    public override void Decorate(Policy target)
    {
        if (target.Users != null)
        {
            if (target.Users is FFnREFList userList)
            {
                if (userList.Results.Count == 1)
                {
                    var user = userList.Results[0] as UserFactory;
                    target.PolicyName = $"{user.Result.UserName}-{target.GivenName}-Policy";
                }
            }
        }
        else
        {
            target.PolicyName = $"{ResourceName}-{target.GivenName}-Policy";
        }
    }

    public string ResourceName { get; set; }
}
using Volo.Abp.Modularity;

namespace Ecommerce;

[DependsOn(
    typeof(EcommerceDomainModule),
    typeof(EcommerceTestBaseModule)
)]
public class EcommerceDomainTestModule : AbpModule
{

}

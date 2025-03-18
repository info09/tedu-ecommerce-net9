using Ecommerce.Samples;
using Xunit;

namespace Ecommerce.EntityFrameworkCore.Applications;

[Collection(EcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EcommerceEntityFrameworkCoreTestModule>
{

}

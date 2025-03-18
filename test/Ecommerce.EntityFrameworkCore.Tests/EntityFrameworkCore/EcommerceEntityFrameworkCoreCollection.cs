using Xunit;

namespace Ecommerce.EntityFrameworkCore;

[CollectionDefinition(EcommerceTestConsts.CollectionDefinitionName)]
public class EcommerceEntityFrameworkCoreCollection : ICollectionFixture<EcommerceEntityFrameworkCoreFixture>
{

}

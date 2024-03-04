using FlowR.Core.Flows;
using FlowR.Core.Tests.Ecommerce.Activities;

namespace FlowR.Core.Tests.Ecommerce;

public class EcommerceUnitTests
{
    [Fact]
    public void the_flow_of_placing_and_delivering_the_order_was_done_successfully()
    {
        // arrange
        var flow = Flow.Initialize()
            .Stage(s =>
            {
                s.Activity = new PlaceOrderActivity();
            }).Stage(s =>
            {
                s.Activity = new StartPaymentActivity();
            }).Stage(s =>
            {
                s.Activity = new CheckPaymentStatusActivity();
            }).Stage(s =>
            {
                s.Activity = new WarehouseUpdateStockProductActivity();
            }).Stage(s =>
            {
                s.Activity = new OrderPreparationActivity();
            }).Stage(s =>
            {
                s.Activity = new SendOrderToCompletionActivity();
            }).Stage(s =>
            {
                s.Activity = new HandOverOrderToCourierActivity();
            }).Stage(s =>
            {
                s.Activity = new CheckOrderDeliveryStatusActivity();
            });
        // act
        var result = flow.Run();
        var dataFromPlaceOrder = result.ChildResults.FirstOrDefault();
        // assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(dataFromPlaceOrder?.Data);
    }
}
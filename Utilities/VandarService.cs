namespace Utilities
{
    public class VandarService
    {
        private string vandarToken;
        public paymentMethod PaymentMethod { get; set; }
        public string GetGateWayToken(int orderId)
        {
            return Guid.NewGuid().ToString();
        }

        public void payOrder(int orderId)
        {
            Console.WriteLine($"order with id of{orderId} paid ");
        }

        public void PrintOrderDetails(int orderId)
        {
            Console.WriteLine($"order with id of {orderId} details printed");
        }

        private bool orderValidation(int orderId)
        {
            return true;
        }
    }

    public enum paymentMethod
    {
        None = 0,
        online=1,
        wallet=2
    }
}
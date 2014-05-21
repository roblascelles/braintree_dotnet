using System;

namespace Braintree
{
    public class UnknownPaymentMethod : PaymentMethod
    {
        public String Token { get; protected set; }

        public UnknownPaymentMethod(NodeWrapper node)
        {
            Token = node.GetString("token");
        }
    }
}

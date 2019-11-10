using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealership.Classes
{
	public static class Class_payment_function
	{
		//		payment_function description
		// MUST MATCH DATABASE TABLE --- [VehicleDealership].[fin].[payment_function]

		public enum PaymentFunction
		{
			VSALE_PAYMENT_RECEIVED = 1,
			VSALE_EXPENSES = 2,
			VSALE_MISC_PAID = 3,
			VSALE_MISC_RECEIVED = 4
		}
	}
}

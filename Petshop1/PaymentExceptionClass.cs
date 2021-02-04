using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class PaymentExceptionClass : ApplicationException
    {
        public string Text { get; set; }

        public PaymentExceptionClass(string text)
        {
            this.Text = text;
        }

    }
}

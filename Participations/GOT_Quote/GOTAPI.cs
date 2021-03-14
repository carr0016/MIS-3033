using System;
using System.Collections.Generic;
using System.Text;

namespace GOT_Quote
{
    public class GOTAPI
    {
        public QuoteInfo quoteInfo { get; set; }

        public class QuoteInfo
        {
            public string quote { get; set; }
            public string character { get; set; }

            public override string ToString()
            {
                return $"{quote} {character}";
            }
        }

    }
}

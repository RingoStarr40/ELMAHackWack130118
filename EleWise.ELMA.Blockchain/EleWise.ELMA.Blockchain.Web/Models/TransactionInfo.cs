using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EleWise.ELMA.Blockchain.Web.Models
{
    public class TransactionInfo
    {
        public string FromId { get; set; }
        public string ToId { get; set; }
        public string Amount { get; set; }
    }
}
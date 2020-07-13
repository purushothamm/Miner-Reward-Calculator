using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFeeCalc
{
    class Transaction
    {
        public int Bytes { get; set; }
        public float Fee { get; set; }
        public float FeePerByte { get; set; }
        public Transaction(int bytes, float fee, float feePerByte)
        {
            Bytes = bytes;
            Fee = fee;
            FeePerByte = feePerByte;
        }
    }
}

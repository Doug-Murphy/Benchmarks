using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ToParenthesesString {
        [Params(false, true)]
        public bool encapsulateInQuote;

        private readonly List<string> list = Enumerable.Repeat("foo", 1_000).ToList();

        [Benchmark(Baseline = true)]
        public string ToParenthesesString_Before() {
            if (list == null) {
                return "";
            }

            int countList = list.Count;
            int countListMinus1 = countList - 1;
            string sQuote = encapsulateInQuote ? "'" : "";
            var sbList = new StringBuilder("(");

            for (var i = 0; i < countList; i++) {
                sbList.Append(sQuote + list[i] + sQuote + (i < countListMinus1 ? "," : ""));
            }

            sbList.Append(")");
            return sbList.ToString();
        }

        [Benchmark]
        public string ToParenthesesString_After() {
            if (list == null) {
                return "";
            }

            if (encapsulateInQuote) {
                //This intentionally does not use string.Join() as you see below.
                //It is noticeably worse in speed and RAM allocation given how you have to handle the addition of single quotes in that scenario
                var sb = new StringBuilder("(");
                for (var i = 0; i < list.Count; i++) {
                    sb.Append("'");
                    sb.Append(list[i]);
                    sb.Append("'");
                    if (i != list.Count - 1) {
                        //if not at end of list, add in a comma
                        sb.Append(",");
                    }
                }

                sb.Append(")");
                return sb.ToString();
            }

            return "(" + string.Join(",", list) + ")";
        }
    }
}

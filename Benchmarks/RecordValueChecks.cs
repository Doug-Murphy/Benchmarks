#if NET5_0_OR_GREATER
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class RecordValueChecks {
        private record RecordPropertyCount1(string Property1);

        private record RecordPropertyCount10(string Property1, string Property2, string Property3, string Property4, string Property5, string Property6, string Property7, string Property8, string Property9, string Property10);

        private record RecordPropertyCount20(string Property1, string Property2, string Property3, string Property4, string Property5, string Property6, string Property7, string Property8, string Property9, string Property10, string Property11, string Property12, string Property13, string Property14, string Property15, string Property16, string Property17, string Property18, string Property19, string Property20);

        private record RecordPropertyCount30(string Property1, string Property2, string Property3, string Property4, string Property5, string Property6, string Property7, string Property8, string Property9, string Property10, string Property11, string Property12, string Property13, string Property14, string Property15, string Property16, string Property17, string Property18, string Property19, string Property20, string Property21, string Property22, string Property23, string Property24, string Property25, string Property26, string Property27, string Property28, string Property29, string Property30);

        private class ClassPropertyCount30 {
            public string Property1 { get; init; }

            public string Property2 { get; init; }

            public string Property3 { get; init; }

            public string Property4 { get; init; }

            public string Property5 { get; init; }

            public string Property6 { get; init; }

            public string Property7 { get; init; }

            public string Property8 { get; init; }

            public string Property9 { get; init; }

            public string Property10 { get; init; }

            public string Property11 { get; init; }

            public string Property12 { get; init; }

            public string Property13 { get; init; }

            public string Property14 { get; init; }

            public string Property15 { get; init; }

            public string Property16 { get; init; }

            public string Property17 { get; init; }

            public string Property18 { get; init; }

            public string Property19 { get; init; }

            public string Property20 { get; init; }

            public string Property21 { get; init; }

            public string Property22 { get; init; }

            public string Property23 { get; init; }

            public string Property24 { get; init; }

            public string Property25 { get; init; }

            public string Property26 { get; init; }

            public string Property27 { get; init; }

            public string Property28 { get; init; }

            public string Property29 { get; init; }

            public string Property30 { get; init; }
        }

        [Benchmark]
        public void RecordCheckProperty1AllSame() {
            var instance1 = new RecordPropertyCount1("1");
            var instance2 = new RecordPropertyCount1("1");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void RecordCheckProperty10AllSame() {
            var instance1 = new RecordPropertyCount10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            var instance2 = new RecordPropertyCount10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void RecordCheckProperty20AllSame() {
            var instance1 = new RecordPropertyCount20("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20");
            var instance2 = new RecordPropertyCount20("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void RecordCheckProperty30AllSame() {
            var instance1 = new RecordPropertyCount30("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30");
            var instance2 = new RecordPropertyCount30("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void RecordCheckProperty20DifferAt10() {
            var instance1 = new RecordPropertyCount20("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20");
            var instance2 = new RecordPropertyCount20("1", "2", "3", "4", "5", "6", "7", "8", "9", "not-10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void RecordCheckProperty30DifferAt20() {
            var instance1 = new RecordPropertyCount30("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30");
            var instance2 = new RecordPropertyCount30("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "not-20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30");
            bool areEqual = instance1 == instance2;
        }

        [Benchmark]
        public void ClassCheckProperty30DifferAt20() {
            var instance1 = new ClassPropertyCount30 {
                Property1 = "1",
                Property2 = "2",
                Property3 = "3",
                Property4 = "4",
                Property5 = "5",
                Property6 = "6",
                Property7 = "7",
                Property8 = "8",
                Property9 = "9",
                Property10 = "10",
                Property11 = "11",
                Property12 = "12",
                Property13 = "13",
                Property14 = "14",
                Property15 = "15",
                Property16 = "16",
                Property17 = "17",
                Property18 = "18",
                Property19 = "19",
                Property20 = "20",
                Property21 = "21",
                Property22 = "22",
                Property23 = "23",
                Property24 = "24",
                Property25 = "25",
                Property26 = "26",
                Property27 = "27",
                Property28 = "28",
                Property29 = "29",
                Property30 = "30",
            };
            var instance2 = new ClassPropertyCount30 {
                Property1 = "1",
                Property2 = "2",
                Property3 = "3",
                Property4 = "4",
                Property5 = "5",
                Property6 = "6",
                Property7 = "7",
                Property8 = "8",
                Property9 = "9",
                Property10 = "10",
                Property11 = "11",
                Property12 = "12",
                Property13 = "13",
                Property14 = "14",
                Property15 = "15",
                Property16 = "16",
                Property17 = "17",
                Property18 = "18",
                Property19 = "19",
                Property20 = "not-20",
                Property21 = "21",
                Property22 = "22",
                Property23 = "23",
                Property24 = "24",
                Property25 = "25",
                Property26 = "26",
                Property27 = "27",
                Property28 = "28",
                Property29 = "29",
                Property30 = "30",
            };

            bool areEqual = instance1 == instance2;
        }
    }
}
#endif

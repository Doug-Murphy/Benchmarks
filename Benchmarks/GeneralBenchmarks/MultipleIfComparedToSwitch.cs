using BenchmarkDotNet.Attributes;

namespace Benchmarks.GeneralBenchmarks {
    [MemoryDiagnoser]
    public class MultipleIfComparedToSwitch {
        private int _intValue = 10;

        [Benchmark]
        public int TenIfStatements() {
            if (_intValue == 1) {
                _intValue += 1;
            }
            if (_intValue == 2) {
                _intValue += 2;
            }
            if (_intValue == 3) {
                _intValue += 3;
            }
            if (_intValue == 4) {
                _intValue += 4;
            }
            if (_intValue == 5) {
                _intValue += 5;
            }
            if (_intValue == 6) {
                _intValue += 6;
            }
            if (_intValue == 7) {
                _intValue += 7;
            }
            if (_intValue == 8) {
                _intValue += 8;
            }
            if (_intValue == 9) {
                _intValue += 9;
            }
            if (_intValue == 10) {
                _intValue += 10;
            }

            return _intValue;
        }

        [Benchmark]
        public int TenIfElseIfStatements() {
            if (_intValue == 1) {
                _intValue += 1;
            }
            else if (_intValue == 2) {
                _intValue += 2;
            }
            else if (_intValue == 3) {
                _intValue += 3;
            }
            else if (_intValue == 4) {
                _intValue += 4;
            }
            else if (_intValue == 5) {
                _intValue += 5;
            }
            else if (_intValue == 6) {
                _intValue += 6;
            }
            else if (_intValue == 7) {
                _intValue += 7;
            }
            else if (_intValue == 8) {
                _intValue += 8;
            }
            else if (_intValue == 9) {
                _intValue += 9;
            }
            else if (_intValue == 10) {
                _intValue += 10;
            }

            return _intValue;
        }

        [Benchmark]
        public int TenCaseStatements() {
            switch (_intValue) {
                case 1:
                    _intValue += 1;
                    break;
                case 2:
                    _intValue += 2;
                    break;
                case 3:
                    _intValue += 3;
                    break;
                case 4:
                    _intValue += 4;
                    break;
                case 5:
                    _intValue += 5;
                    break;
                case 6:
                    _intValue += 6;
                    break;
                case 7:
                    _intValue += 7;
                    break;
                case 8:
                    _intValue += 8;
                    break;
                case 9:
                    _intValue += 9;
                    break;
                case 10:
                    _intValue += 10;
                    break;
            }

            return _intValue;
        }
    }
}

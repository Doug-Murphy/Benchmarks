using BenchmarkDotNet.Attributes;
using System;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class TryCatchMethodCallStack {
        [Benchmark]
        public void TopLevelTryCatchOnly() {
            try {
                ChildLevel1WithoutTryCatch();
            }
            catch (Exception) {
                //do nothing
            }
        }
        private void ChildLevel1WithoutTryCatch() {
            ChildLevel2WithoutTryCatch();
        }
        private void ChildLevel2WithoutTryCatch() {
            ChildLevel3WithoutTryCatch();
        }
        private void ChildLevel3WithoutTryCatch() {
            throw new Exception("Exception message.");
        }


        [Benchmark]
        public void TopLevelAndChildLevelCatches() {
            try {
                ChildLevel1WithTryCatch();
            }
            catch (Exception) {
                //do nothing
            }
        }
        private void ChildLevel1WithTryCatch() {
            try {
                ChildLevel2WithTryCatch();
            }
            catch (Exception) {
                throw;
            }
        }
        private void ChildLevel2WithTryCatch() {
            try {
                ChildLevel3WithTryCatch();
            }
            catch (Exception) {
                throw;
            }
        }
        private void ChildLevel3WithTryCatch() {
            try {
                throw new Exception("Exception message.");
            }
            catch (Exception) {
                throw;
            }
        }


        [Benchmark]
        public void TopLevelAndChildLevelCatchesWithThrowNew() {
            try {
                ChildLevel1WithTryCatchWithThrowNew();
            }
            catch (Exception) {
                //do nothing
            }
        }
        private void ChildLevel1WithTryCatchWithThrowNew() {
            try {
                ChildLevel2WithTryCatchWithThrowNew();
            }
            catch (Exception ex) {
                throw new Exception("Exception container.", ex);
            }
        }
        private void ChildLevel2WithTryCatchWithThrowNew() {
            try {
                ChildLevel3WithTryCatchWithThrowNew();
            }
            catch (Exception ex) {
                throw new Exception("Exception container.", ex);
            }
        }
        private void ChildLevel3WithTryCatchWithThrowNew() {
            try {
                throw new Exception("Exception message.");
            }
            catch (Exception ex) {
                throw new Exception("Exception container.", ex); 
            }
        }
    }
}

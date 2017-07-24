using System;
using NUnit.Framework;
using static BinarySearchLogic.GenericBinarySearch;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace BinarySearchLogic.Tests
{
    [TestFixture]
    public class GenericBinaryLogicTests
    {
        private static IEnumerable<TestCaseData> BinarySearch_PositiveData
        {
            get {
                yield return new TestCaseData(
                        new[] { "a", "bd", "cdd", "mno", "xxx" },
                        "xxx").
                    Returns(4);

                yield return new TestCaseData(
                        new[] { 1.0, 15.4, 16.6, 20.1, 44.4 },
                        1.0).
                    Returns(0);
                
                yield return new TestCaseData(
                        new[] { 15, 22, 46, 70, 95 },
                        70).
                    Returns(3);

                yield return new TestCaseData(
                        new[] { 'a', 'c', 'k', 'm', 'x' },
                        'c').
                    Returns(1);


                yield return new TestCaseData(
                        new[] { 'a', 'c', 'k', 'm', 'x' },
                        'f').
                    Returns(-1);
            }
        }


        private static IEnumerable<TestCaseData> BinarySearch_ThrowsRuntimeBinderExceptionData
        {
            get
            {
                yield return new TestCaseData(
                    't',
                    'f');

                yield return new TestCaseData(
                    1,
                    4);

                yield return new TestCaseData(
                    new []{1,2,3,5,6,7,8},
                    new []{"a", "d", "a"});
            }
        }


        [Test, TestCaseSource(nameof(BinarySearch_PositiveData))]
        public int BinarySearch_PositiveTests(dynamic arr, dynamic value)//?
        {
            return BinarySearch(arr, value);
        }

        [Test, TestCaseSource(nameof(BinarySearch_ThrowsRuntimeBinderExceptionData))]
        public void BinarySearch_ThrowsRuntimeBinderException(dynamic arr, dynamic value)
        {
            Assert.Throws<RuntimeBinderException>(() => BinarySearch(arr, value));
        }
    }
}

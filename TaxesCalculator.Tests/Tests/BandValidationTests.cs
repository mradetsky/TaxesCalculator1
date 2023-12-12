
using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaxesCalculator.BLL.Extensions;
using TaxesCalculator.DAL.Entities;


namespace TaxesCalculator.Tests.Tests
{
    public class BandValidationTests
    {
        [SetUp]
        public void Setup()
        {

        }

        public static List<object[]> TestCases = new List<object[]>()
            {
                new object[]{new List<Band>()
                    {
                        new Band(){Order= 1, SalaryRangeFrom = 6}
                    },
                    "SalaryRangeFrom or first band should be null!"
                },
                new object[]{new List<Band>()
                    {
                        new Band(){Order= 1, SalaryRangeTo = 6}
                    },
                    "SalaryRangeTo or last band should be null!"
                },
                new object[]{new List<Band>()
                    {
                        new Band(){Order= 1, SalaryRangeTo = 6},
                        new Band(){Order= 2, SalaryRangeFrom = 5}
                    },
                    "SalaryRangeFrom should be equal of SalaryRangeTo of previous band!"
                },
                new object[]{new List<Band>()
                    {
                        new Band(){Order= 1, SalaryRangeTo = 5},
                        new Band(){Order= 2, SalaryRangeFrom = 5}
                    },
                    null
                }
            };


        [Test]
        [TestCaseSource(nameof(TestCases))]

        public void TestBandsValidation(List<Band> bands, string exception)
        {
            if (!string.IsNullOrEmpty(exception))
            {
                var ex = Assert.Throws<ValidationException>(() =>
                {
                    bands.ValidateBands();
                });
                Assert.AreEqual(exception, ex.Message);
            }
            else
            {
                bands.ValidateBands();
            }



        }
    }
}
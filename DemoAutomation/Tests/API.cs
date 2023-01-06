using Boa.Constrictor.RestSharp;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace DemoAutomation.Tests
{
    internal class API : TestBase
    {
        public static IRestRequest GetDepartments() 
            => new RestRequest("departments", Method.GET);

    }

    class APITest : TestBase
    {
        [SetUp]
        public void Before()
        {
            Nami.Can(CallRestApi.Using(new RestClient("https://www.mercadolibre.com.ar/menu/departments")));
        }

        [Test, Ignore("test en desarrollo, no se pudo implementar")]
        public void TestMLDepartmentsApiStatusCode()
        {
            /* response */
            Nami.Calls(Rest.Request(API.GetDepartments()))
                .StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}

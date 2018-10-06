using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutofacContrib.NSubstitute.Tests
{
    [TestFixture]
    public class ConcreteClassesResolvingFixture
    {

        public class ConcreteClassWithNoConstructor
        {
            public int A { get; set; }
            public string Str { get; set; }
        }

        public class ConcreteClassWithTwoConstructors
        {
            private readonly ConcreteClassWithNoConstructor _concreteClassWithNoConstructor;
            private readonly int _i;
            private readonly string _str;
            private readonly IDependency1 _dependency1;
            private readonly IDependency2 _dependency2;
            private readonly DateTime _dt;

            public ConcreteClassWithTwoConstructors(ConcreteClassWithNoConstructor concreteClassWithNoConstructor, int i, string str, IDependency1 dependency1, IDependency2 dependency2, DateTime dt)
            {
                _concreteClassWithNoConstructor = concreteClassWithNoConstructor;
                _i = i;
                _str = str;
                _dependency1 = dependency1;
                _dependency2 = dependency2;
                _dt = dt;
            }

            public ConcreteClassWithTwoConstructors(IDependency1 dependency1, DateTime dt, )
            {
                
            }
        }

        [Test]
        public void Test_1()
        {
            var autosubstitute = new AutoSubstitute();
            var mock = autosubstitute.Resolve<MyClassWithConcreteDependency>();
        }

        [Test]
        public void Test_2()
        {
            var autosubstitute = new AutoSubstitute();
            var mock = autosubstitute.Resolve<MyClassWithConcreteDependency>();
        }

        [Test]
        public void Test_3()
        {
            var autosubstitute = new AutoSubstitute();
            var mock = autosubstitute.Resolve<ConcreteClassWithNoConstructor>();
        }

    }
}

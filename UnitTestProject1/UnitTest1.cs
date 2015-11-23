using System;
using TestStack.ConventionTests;
using ConsoleApplication1;
using TestStack.ConventionTests.ConventionData;
using TestStack.ConventionTests.Conventions;
using Xunit;
namespace UnitTestProject1
{
    
    public class UnitTest1
    {
        [Fact]
        public void EnsureParameterLessConstructor()
        {
            var res = Types.InAssemblyOf<Parent>(x => x.GetInterface("IMonInterface") != null);
          
           Convention.Is(new AllClassesHaveDefaultConstructor(), res, new ConventionTestResultProcessor());
                
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.ConventionTests;
using TestStack.ConventionTests.ConventionData;

namespace UnitTestProject1
{
    public class AllClassImplementingIMonInterfaceShouldHaveDefaultConstructor : IConvention<Types>
    {
        public string ConventionReason
        {
            get
            {
                return "Utile pour eviter les soucis avec Activator.";
            }
        }

        public void Execute(Types data, IConventionResultContext result)
        {
            result.Is("Toutes les classes non abstraites implementant IMonInterface doivent avoir un constructeur sans paramètre.",
                data.Where(x => x.IsConcreteClass() && x.GetInterface("IMonInterface") != null)
                .Where(x => !x.GetConstructors().Any(y => y.GetParameters().Length == 0))
                );
        }
    }
}

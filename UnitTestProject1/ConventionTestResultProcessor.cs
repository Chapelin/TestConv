using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.ConventionTests.Internal;
using TestStack.ConventionTests.Reporting;

namespace UnitTestProject1
{
    public class ConventionTestResultProcessor : ITestResultProcessor
    {
        public string RecommendedFileExtension
        {
            get
            {
                return ".txt";
            }
        }

        public string Process(IConventionFormatContext context, ConventionResult result)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Il y a ").Append(result.Data.Length).AppendLine(" types en erreur : ");
            foreach(var t in result.Data)
            {
                sb.AppendLine(((Type)t).Name);
            }
            return sb.ToString();
        }
    }
}

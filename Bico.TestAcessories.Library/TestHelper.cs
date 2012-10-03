using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bico.TestAcessories.Library
{
    public class TestHelper : ITestHelper
    {
        public string[] LoadInput(string path)
        {
            throw new NotImplementedException();
        }

        public VerificationResult VerifyInput(string path,string[] result)
        {
            return new VerificationResult
            {
                
            };
            throw new NotImplementedException();
        }
    }
}

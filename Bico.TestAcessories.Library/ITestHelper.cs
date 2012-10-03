using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bico.TestAcessories.Library
{
    public interface ITestHelper
    {
        string[] LoadInput(string path);
        VerificationResult VerifyInput(string path, string[] result);
    }
}

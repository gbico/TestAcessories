using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bico.TestAcessories.Library
{
    public class VerificationResult
    {
        public bool     Correctly           { get; set; }
        public int      NumberCorrect       { get; set; }
        public bool[]   CorrectResults      { get; set; }
    }
}

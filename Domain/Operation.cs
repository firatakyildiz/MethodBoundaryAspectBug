using System;

namespace Domain
{
    [SampleValidation]
    public class Operation
    {
        public string SampleMethod()
        {
            var test = 3;
            var someVar = "qwe";
            var result = false;
            if (test == 5)
            {
                result = true;
            }
            return "success";
        }
    }
}

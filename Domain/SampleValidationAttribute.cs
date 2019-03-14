using System;
using System.Collections.Generic;
using System.Text;
using MethodBoundaryAspect.Fody.Attributes;

namespace Domain
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SampleValidation : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            var test = 3;

        }
    }
}

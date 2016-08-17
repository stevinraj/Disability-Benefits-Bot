using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable 649

namespace Microsoft.Bot.Sample.BenfiBot
{
     
    public enum DizOptions
    {
        Unkown, Mental, Visual, Speech, Locomotor

    };
    


    [Serializable]
    class GetBenefits
    {
        public int Age;
        public DizOptions Kind;
         
                public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("GetBenefits({0}, {1}, ", Age, Kind);
      
            return builder.ToString();
        }
    };
}


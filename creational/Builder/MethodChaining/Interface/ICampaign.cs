using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChaining.Interface
{
    internal interface ICampaign
    {
        IScenario AddScenario(Scenario scenario);
    }
}

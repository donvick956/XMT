using System;
using System.Collections.Generic;
using GroupExperiment.Modules.Models;

namespace GroupExperiment.Modules
{
    public class BeneficiaryGroup
    {
        public string GroupName { get; set; }
        public List<Recipient> Recipients { get; set; }


        public BeneficiaryGroup(string groupName)
        {
            GroupName = groupName;
            Recipients = new List<Recipient>();
        }
    }
}

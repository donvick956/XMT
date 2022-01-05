using System;
using System.Collections.Generic;

namespace GroupExperiment.Modules
{
    public class BeneficiaryGroup
    {
        public string GroupName { get; set; }
        public int NumOfRecipients { get; }
        public List<Recipient> Recipients { get; set; }

        public BeneficiaryGroup(string groupName)
        {
            GroupName = groupName;
            Recipients = new List<Recipient>();
            NumOfRecipients = Recipients.Count;
        }
    }
}

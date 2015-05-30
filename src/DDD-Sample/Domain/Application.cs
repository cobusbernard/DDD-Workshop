using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Sample.Domain
{
    public class Application
    {
        public Guid ApplicationId { get; private set; }
        public DateTime ApplicationDateTime { get; private set; }
        public Applicant Applicant { get; private set; }
        public ApplicationStatus Status { get; private set; }

        public Application(Applicant applicant)
        {
            Applicant = applicant;
            Status = ApplicationStatus.Applied;
        }

        public string GetApplicantFullName()
        {
            return Applicant.GetApplicantFullName();
        }

        public void Approve()
        {
            if (ApplicationStatus.Applied != Status)
                Status = ApplicationStatus.Approved;
        }

        public void Decline()
        {
            Status = ApplicationStatus.Declined;
        }
    }

    public enum ApplicationStatus
    {
        Applied,
        Approved,
        Declined
    }
}

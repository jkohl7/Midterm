using System;
using System.Collections.Generic;
using System.Text;

namespace TicketObject
{
    class Ticket
    {
    
        private string id, summ, status, prio, submit, assn, watch, severity, software, cost, reason, estimate, projectname, duedate ;


        public Ticket(string id, string summ, string status, string prio, string submit, string assn, string watch, string severity, string cost, string reason, string estimate, string projectname, string duedate)
        {
            this.id = id;
            this.summ = summ;
            this.status = status;
            this.prio = prio;
            this.submit = submit;
            this.assn = assn;
            this.watch = watch;
            this.severity = severity;
        }

   

        public string getId()
        {
            return id;
        }

        public string getSumm()
        {
            return summ;
        }
        public string getStatus()
        {
            return status;
        }

        public string getPrio()
        {
            return prio;
        }

        public string getSubmit()
        {
            return submit;
        }

        public string getAssn()
        {
            return assn;
        }

        public string getWatch()
        {
            return watch;
        }

        public string getSeverity()
        {
            return severity;
        }


    }




}
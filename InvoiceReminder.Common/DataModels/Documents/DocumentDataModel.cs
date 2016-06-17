﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceReminder.Common.DataModels.Documents
{
    public class DocumentDataModel : BaseDataModel<int>
    {
        public string Name { get; set; }
        public DateTime SubmitedDate { get; set; }
        public string FileHash { get; set; }

        //public virtual DocumentTypeDataModel DocType { get; set; }
        public virtual ReminderDataModel Reminder { get; set; }
    }
}

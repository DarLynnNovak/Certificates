﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Certificates.Models
{
	public class ACSCMEEvent
	{
        public int ID { get; set; }

        public int ParentID { get; set; }

        public string Name { get; set; }

        public string CME_Program { get; set; }

        public string CME_Location { get; set; }

        public DateTime CME_Start_Date { get; set; }

        public DateTime CME_End_Date { get; set; }

        public int ACSCMECertTemplate_ID { get; set; }

        public string CertLine1 { get; set; }
        public string CertLine2 { get; set; }

        public int EventType { get; set; }

        public decimal CME_Max_Credits { get; set; }
        public decimal SACME_Max_Credits { get; set; }
        public decimal CE_Max_Credits { get; set; }
        public decimal SACE_Max_Credits { get; set; }

        public string CertificateVersion { get; set; }

        public int CMETypeID { get; set; }

        [NotMapped]
        
        public DateTime DateGranted { get; set; }

        public int CMETestTemplateId { get; set; }
    }
}

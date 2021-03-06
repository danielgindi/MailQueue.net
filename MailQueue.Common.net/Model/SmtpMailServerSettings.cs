﻿using System.Xml.Serialization;

namespace MailQueue
{
    [XmlRoot(ElementName = "Smtp")]
    public class SmtpMailServerSettings : IMailServerSettings
    {
        public const string TYPE = "Smtp";

        public SmtpMailServerSettings()
        {
        }

        [XmlIgnore]
        public override string Type { get { return TYPE; } }

        [XmlIgnore]
        public override bool IsEmpty { get { return string.IsNullOrEmpty(Host); } }

        public string Host { get; set; }
        public int Port { get; set; }
        public bool RequiresSsl { get; set; }
        public bool RequiresAuthentication { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// The number of milliseconds to wait before the request times out.
        /// The default value is 100,000 milliseconds (100 seconds).
        /// </summary>
        public int ConnectionTimeout { get; set; } = 100000;
    }
}

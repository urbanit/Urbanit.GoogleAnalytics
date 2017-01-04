using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Urbanit.GoogleAnalytics.Models
{
    public class SettingsRecord
    {
        public virtual int Id { get; set; }
        public virtual bool Enable { get; set; }
        public virtual string Script { get; set; }
    }
}
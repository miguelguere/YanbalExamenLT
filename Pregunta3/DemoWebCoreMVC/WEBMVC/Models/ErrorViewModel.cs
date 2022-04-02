using System;

namespace WEBMVC.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string MessageException { get; set; }
        public string InnerException { get; set; }

    }
}

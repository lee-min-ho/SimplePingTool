﻿using System;

namespace PingData
{
    public class PingResult
    {
        /// <summary>
        /// the latency in milliseconds for the ping to complete
        /// </summary>
        public int Latency { get; set; }

        /// <summary>
        /// The address or ip of the ping destination
        /// </summary>
        public string AddressOrIp { get; set; }

        /// <summary>
        /// The status associated with the completed ping request
        /// </summary>
        public PingHost.Status Status { get; set; }

        /// <summary>
        /// the status code associated with the completed ping request
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// the error message associated to the ping request, if any
        /// </summary>
        public string ErrorMessage { get; set; }
        
        /// <summary>
        /// The timestamp of when the ping request was sent
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
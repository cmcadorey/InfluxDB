﻿// <copyright file="MetricsInfluxDBLineProtocolOptions.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System;
using App.Metrics.Formatters.InfluxDB.Internal;

namespace App.Metrics.Formatters.InfluxDB
{
    public class MetricsInfluxDBLineProtocolOptions
    {
        public MetricsInfluxDBLineProtocolOptions()
        {
            MetricNameMapping = new GeneratedMetricNameMapping();
            MetricNameFormatter = InfluxDBFormatterConstants.LineProtocol.MetricNameFormatter;
        }

        public Func<string, string, string> MetricNameFormatter { get; set; }

        public GeneratedMetricNameMapping MetricNameMapping { get; set; }
    }
}

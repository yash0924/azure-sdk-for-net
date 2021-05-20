// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// Anomaly detection using multiple machine learning algorithms.
    /// </summary>
    public partial class SmartDetectionCondition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartDetectionCondition"/> class.
        /// </summary>
        public SmartDetectionCondition()
        {
        }

        internal SmartDetectionCondition(double sensitivity, AnomalyDetectorDirection anomalyDetectorDirection, SuppressCondition suppressCondition)
        {
            if (suppressCondition == null)
            {
                throw new ArgumentNullException(nameof(suppressCondition));
            }

            Sensitivity = sensitivity;
            AnomalyDetectorDirection = anomalyDetectorDirection;
            SuppressCondition = suppressCondition;
        }

        /// <summary>
        /// A numerical value to adjust the tolerance of the anomaly detection with a range of (0, 100].
        /// Visually, the higher the value, the narrower the upper and lower boundaries around the time series.
        /// </summary>
        public double? Sensitivity { get; set; }

        /// <summary>
        /// A point is an anomaly only when the deviation occurs in the specified direction.
        /// </summary>
        public AnomalyDetectorDirection? AnomalyDetectorDirection { get; set; }

        /// <summary>
        /// The <see cref="Models.SuppressCondition"/> to be applied to every unexpected data point.
        /// </summary>
        public SuppressCondition SuppressCondition { get; set; }

        internal SmartDetectionConditionPatch GetPatchModel() => new SmartDetectionConditionPatch()
        {
            Sensitivity = Sensitivity,
            AnomalyDetectorDirection = AnomalyDetectorDirection,
            SuppressCondition = SuppressCondition.GetPatchModel()
        };
    }
}

﻿using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class RadialLinearTick : RadialTick
    {
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        public ChartColor BackdropColor { get; set; }

        [JsonConverter(typeof(PaddingConverter))]
        public Padding BackdropPadding { get; set; }

        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        public int? MaxTicksLimit { get; set; }

        /// <summary>
        /// User defined fixed step size for the scale.
        /// </summary>
        public double? StepSize { get; set; }

        /// <summary>
        /// Adjustment used when calculating the maximum data value.
        /// </summary>
        public double? SuggestedMax { get; set; }

        /// <summary>
        /// Adjustment used when calculating the minimum data value.
        /// </summary>
        public double? SuggestedMin { get; set; }

        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        public bool? ShowLabelBackdrop { get; set; }
    }
}

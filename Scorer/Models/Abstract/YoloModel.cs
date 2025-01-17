﻿using System.Collections.Generic;
using Scorer.YoloParser;


namespace Scorer.Models.Abstract
{
    /// <summary>
    /// Model descriptor.
    /// </summary>
    public abstract class YoloModel
    {
        public abstract int Width { get; }

        public abstract int Height { get; }

        public abstract int Depth { get; }

        public abstract int Dimensions { get; }

        public abstract float Confidence { get; }

        public abstract float MulConfidence { get; }

        public abstract float Overlap { get; }

        public abstract string Weights { get; }

        public List<YoloLabel> Labels { get; protected set; }

        public bool Ready { get; set; }
    }
}

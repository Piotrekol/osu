// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Difficulty;

namespace osu.Game.Rulesets.Osu.Difficulty
{
    public class OsuDifficultyAttributes : DifficultyAttributes, IComparable<OsuDifficultyAttributes>
    {
        public double AimStrain { get; set; }
        public double SpeedStrain { get; set; }
        public double FlashlightRating { get; set; }
        public double SliderFactor { get; set; }
        public double ApproachRate { get; set; }
        public double OverallDifficulty { get; set; }
        public double DrainRate { get; set; }
        public int HitCircleCount { get; set; }
        public int SliderCount { get; set; }
        public int SpinnerCount { get; set; }

        public override int CompareTo(DifficultyAttributes other)
        {
            if(other is OsuDifficultyAttributes attributes)
                return CompareTo(attributes);
            return 1;
        }

        public int CompareTo(OsuDifficultyAttributes other)
        {
            int difficultyAttributesComparison = base.CompareTo(other);
            if (difficultyAttributesComparison != 0) return difficultyAttributesComparison;
            int aimStrainComparison = AimStrain.CompareTo(other.AimStrain);
            if (aimStrainComparison != 0) return aimStrainComparison;
            int speedStrainComparison = SpeedStrain.CompareTo(other.SpeedStrain);
            if (speedStrainComparison != 0) return speedStrainComparison;
            int approachRateComparison = ApproachRate.CompareTo(other.ApproachRate);
            if (approachRateComparison != 0) return approachRateComparison;
            int overallDifficultyComparison = OverallDifficulty.CompareTo(other.OverallDifficulty);
            if (overallDifficultyComparison != 0) return overallDifficultyComparison;
            int hitCircleCountComparison = HitCircleCount.CompareTo(other.HitCircleCount);
            if (hitCircleCountComparison != 0) return hitCircleCountComparison;
            int spinnerCountComparison = SpinnerCount.CompareTo(other.SpinnerCount);
            if (spinnerCountComparison != 0) return spinnerCountComparison;
            return SliderCount.CompareTo(other.SliderCount);
        }
    }
}

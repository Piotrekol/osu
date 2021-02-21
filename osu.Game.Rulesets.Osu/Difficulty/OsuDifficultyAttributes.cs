// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Difficulty;

namespace osu.Game.Rulesets.Osu.Difficulty
{
    public class OsuDifficultyAttributes : DifficultyAttributes, IComparable<OsuDifficultyAttributes>
    {
        public double AimStrain;
        public double SpeedStrain;
        public double ApproachRate;
        public double OverallDifficulty;
        public int HitCircleCount;
        public int SpinnerCount;
        public int SliderCount;

        public override int CompareTo(DifficultyAttributes other)
        {
            if(other is OsuDifficultyAttributes attributes)
                return CompareTo(attributes);
            return 1;
        }

        public int CompareTo(OsuDifficultyAttributes other)
        {
            var difficultyAttributesComparison = base.CompareTo(other);
            if (difficultyAttributesComparison != 0) return difficultyAttributesComparison;
            var aimStrainComparison = AimStrain.CompareTo(other.AimStrain);
            if (aimStrainComparison != 0) return aimStrainComparison;
            var speedStrainComparison = SpeedStrain.CompareTo(other.SpeedStrain);
            if (speedStrainComparison != 0) return speedStrainComparison;
            var approachRateComparison = ApproachRate.CompareTo(other.ApproachRate);
            if (approachRateComparison != 0) return approachRateComparison;
            var overallDifficultyComparison = OverallDifficulty.CompareTo(other.OverallDifficulty);
            if (overallDifficultyComparison != 0) return overallDifficultyComparison;
            var hitCircleCountComparison = HitCircleCount.CompareTo(other.HitCircleCount);
            if (hitCircleCountComparison != 0) return hitCircleCountComparison;
            var spinnerCountComparison = SpinnerCount.CompareTo(other.SpinnerCount);
            if (spinnerCountComparison != 0) return spinnerCountComparison;
            return SliderCount.CompareTo(other.SliderCount);
        }
    }
}

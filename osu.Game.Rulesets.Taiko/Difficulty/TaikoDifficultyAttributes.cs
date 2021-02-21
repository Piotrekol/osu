// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Difficulty;

namespace osu.Game.Rulesets.Taiko.Difficulty
{
    public class TaikoDifficultyAttributes : DifficultyAttributes, IComparable<TaikoDifficultyAttributes>
    {
        public double StaminaStrain;
        public double RhythmStrain;
        public double ColourStrain;
        public double ApproachRate;
        public double GreatHitWindow;

        public override int CompareTo(DifficultyAttributes other)
        {
            if (other is TaikoDifficultyAttributes attributes)
                return CompareTo(attributes);
            return 1;
        }

        public int CompareTo(TaikoDifficultyAttributes other)
        {
            var difficultyAttributesComparison = base.CompareTo(other);
            if (difficultyAttributesComparison != 0) return difficultyAttributesComparison;
            var staminaStrainComparison = StaminaStrain.CompareTo(other.StaminaStrain);
            if (staminaStrainComparison != 0) return staminaStrainComparison;
            var rhythmStrainComparison = RhythmStrain.CompareTo(other.RhythmStrain);
            if (rhythmStrainComparison != 0) return rhythmStrainComparison;
            var colourStrainComparison = ColourStrain.CompareTo(other.ColourStrain);
            if (colourStrainComparison != 0) return colourStrainComparison;
            var approachRateComparison = ApproachRate.CompareTo(other.ApproachRate);
            if (approachRateComparison != 0) return approachRateComparison;
            return GreatHitWindow.CompareTo(other.GreatHitWindow);
        }
    }
}

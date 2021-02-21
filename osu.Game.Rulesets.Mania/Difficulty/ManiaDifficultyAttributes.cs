// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Difficulty;

namespace osu.Game.Rulesets.Mania.Difficulty
{
    public class ManiaDifficultyAttributes : DifficultyAttributes, IComparable<ManiaDifficultyAttributes>
    {
        public double GreatHitWindow;
        public double ScoreMultiplier;

        public override int CompareTo(DifficultyAttributes other)
        {
            if (other is ManiaDifficultyAttributes attributes)
                return CompareTo(attributes);
            return 1;
        }

        public int CompareTo(ManiaDifficultyAttributes other)
        {
            var difficultyAttributesComparison = base.CompareTo(other);
            if (difficultyAttributesComparison != 0) return difficultyAttributesComparison;
            var greatHitWindowComparison = GreatHitWindow.CompareTo(other.GreatHitWindow);
            if (greatHitWindowComparison != 0) return greatHitWindowComparison;
            return ScoreMultiplier.CompareTo(other.ScoreMultiplier);
        }
    }
}

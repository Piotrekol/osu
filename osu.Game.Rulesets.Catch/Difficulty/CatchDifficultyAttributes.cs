// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Difficulty;

namespace osu.Game.Rulesets.Catch.Difficulty
{
    public class CatchDifficultyAttributes : DifficultyAttributes, IComparable<CatchDifficultyAttributes>
    {
        public double ApproachRate;

        public override int CompareTo(DifficultyAttributes other)
        {
            if (other is CatchDifficultyAttributes attributes)
                return CompareTo(attributes);
            return 1;
        }

        public int CompareTo(CatchDifficultyAttributes other)
        {
            var difficultyAttributesComparison = base.CompareTo(other);
            if (difficultyAttributesComparison != 0) return difficultyAttributesComparison;
            return ApproachRate.CompareTo(other.ApproachRate);
        }
    }
}

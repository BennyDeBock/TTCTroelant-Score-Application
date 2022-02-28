using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;
using Domain.Common;

namespace Domain.ScoreApp
{
    public class Point : ValueObject
    {
        public uint Value { get; private set; }

        public Point(uint value)
        {
            Guard.Against.Null(value, nameof(value));
            Value = (uint) Guard.Against.Negative(value, nameof(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static implicit operator uint(Point point) => point.Value;
        public static implicit operator Point(uint value) => new(value);
    }
}

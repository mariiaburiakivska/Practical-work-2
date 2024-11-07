using System;

namespace GeometricProgressionLibrary
{
    public class GeometricProgression : IGeometricProgression
    {
        public double InitialElement { get; set; }
        public double Ratio { get; set; }

        public GeometricProgression()
        {
            InitialElement = 1;
            Ratio = 1;
        }
        public GeometricProgression(double initialElement, double ratio)
        {
            InitialElement = initialElement;
            Ratio = ratio;
        }
        public GeometricProgression(GeometricProgression other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "Can't copy from a null object.");
      
            InitialElement = other.InitialElement;
            Ratio = other.Ratio;
        }

        public static GeometricProgression operator +(GeometricProgression progression1, GeometricProgression progression2)
        {
            if (progression1.Ratio != progression2.Ratio)
                throw new InvalidOperationException("Progressions have different ratios");

            return new GeometricProgression(progression1.InitialElement + progression2.InitialElement, progression1.Ratio);
        }

        public static GeometricProgression operator -(GeometricProgression progression1, GeometricProgression progression2)
        {
            if (progression1.Ratio != progression2.Ratio)
                throw new InvalidOperationException("Progressions have different ratios");

            return new GeometricProgression(progression1.InitialElement - progression2.InitialElement, progression1.Ratio);
        }

        public static GeometricProgression operator *(GeometricProgression progression, double number)
        {
            return new GeometricProgression(progression.InitialElement * number, progression.Ratio);
        }

        public static bool operator ==(GeometricProgression progression1, GeometricProgression progression2)
        {
            if (object.Equals(progression1, null) || object.Equals(progression2, null))
                return object.Equals(progression1, progression2);

            if (progression1.InitialElement == progression2.InitialElement && progression1.Ratio == progression2.Ratio)
                return true;

            return false;
        }

        public static bool operator !=(GeometricProgression progression1, GeometricProgression progression2)
        {
            return !(progression1 == progression2);
        }

        public static bool operator >=(GeometricProgression progression1, GeometricProgression progression2)
        {
            if (progression1 != null && progression2 == null)
                return true;

            if (progression1 == null && progression2 != null)
                return false;

            if (progression1 == null && progression2 == null)
                return true;

            return progression1.InitialElement >= progression2.InitialElement;
        }

        public static bool operator <=(GeometricProgression progression1, GeometricProgression progression2)
        {
            if (progression1 == null && progression2 != null)
                return true;

            if (progression1 != null && progression2 == null)
                return false;

            if (progression1 == null && progression2 == null)
                return true;

            return progression1.InitialElement <= progression2.InitialElement;
        }

        public static explicit operator double(GeometricProgression progression)
        {
            return progression.InitialElement;
        }

        public static implicit operator GeometricProgression(double initialElement)
        {
            return new GeometricProgression(initialElement, 1);
        }

        public double GetElement(int index)
        {
            if (index < 1)
                throw new ArgumentOutOfRangeException("Index must be > 0");

            return InitialElement * Math.Pow(Ratio, index - 1);
        }

        public override bool Equals(object obj)
        {
            return obj is GeometricProgression progression1 &&
            InitialElement == progression1.InitialElement &&
            Ratio == progression1.Ratio;
        }

        public override string ToString()
        {
            return $"({InitialElement}, {Ratio})";
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + InitialElement.GetHashCode();
            hash = hash * 23 + Ratio.GetHashCode();
            return hash;
        }
    }
}

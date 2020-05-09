    interface IComparison
    {
        public static bool Equals(RatNumber objA, RatNumber objB)
        {
            return objA != null && objB != null && objA.Equals(objB);
        }

        public static int GetHashCode(object obj)
        {
            if (obj == null)
                return 0;
            return obj.GetHashCode();
        }

        public static float Comparison(RatNumber a, RatNumber b)
        {
            if (a == null || b == null)
                return 0;
            if (!a.Equals(b))
                return (float)(a - b);
            return 0;
        }
    }
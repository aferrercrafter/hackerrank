namespace codility.perm_missing_element
{
    public class PermMissingElement
    {
        public int Solution(int[] A)
        {
            if (A == null)
                return 1;

            long sum = 0;

            foreach (int n in A)
                sum += n;

            long exp = ((A.Length + 1L) * (A.Length + 2L)) / 2L;

            return (int)(exp - sum);
        }
    }
}

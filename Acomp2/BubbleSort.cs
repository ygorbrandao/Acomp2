namespace Acomp2
{
    class BubbleSort : ISort
    {
        public void Sort(int[] E, int n)
        {
            for (int i = 0; i < n; i++) //(1)
            {
                for (int j = 1; j < n; j++) //(2)
                {
                    if (E[j-1] > E[j]) //(3)
                    {
                        int x = E[j-1]; //(4)
                        E[j-1] = E[j]; //(5)
                        E[j] = x; //(6)
                    }
                }
            }
        }
    }
}

namespace Collection_C_
{
    public class ArraysList
    {
        private int n;
        private List<int> numbers = new List<int>();

        public void Nhap(int n)
        {
            int input;
            
            for (int i = 0; i < n; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }
        } 
        public void Xuat(int n)
        {
            for (int i = 0;i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                Console.Write("\t");
            }
        }
        public void SapXep(int n)
        {
            numbers.Sort();
        }
    }
}

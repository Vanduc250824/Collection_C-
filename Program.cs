using Collection_C_;
public class Program
{
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        ArraysList ls = new ArraysList();
        
            ls.Nhap(n);
            ls.SapXep(n);
        
            ls.Xuat(n);

        Hashtables hts = new Hashtables();
        hts.Nhap();
        hts.Xuat();

        Dictonarys d =  new Dictonarys();
        d.Add();
        d.Hienthi();
        
    }
}
// See https://aka.ms/new-console-template for more information



//Kvadr df = Kvadr.Parse(Console.ReadLine());
//Kvadr.dert("45+22+3=0");
Kvadr df = new Kvadr();
string var = "-5x + 10 = 0";
df=Kvadr.Parse(var);
Console.WriteLine(df);
Console.WriteLine("Корень линейного уравнения: ");
Console.WriteLine ( df.getX());

//Console.WriteLine(Kvadr.getX());

class Kvadr
    {
   private int a=0;
   private int b=0;
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    public int B
    {
        get { return b; }
        set { b = value; }
    }


	public static  Kvadr Parse  (string var2)
	{
        Kvadr one = new Kvadr();
        string [] app = var2.Split('x', '+', '='); //"5x + 10 = 0"
        one.A = Convert.ToInt32(app[0]);
       // Console.WriteLine("обьект ",one.A);
        one.B = Convert.ToInt32(app[2]);
        //Console.WriteLine("обьект ",one.B);
       
        return one;
	}
    public double getX()
    {
        if (this.a == 0)
            return 0;
        else
        {

            double x = (double)(this.b * -1) / (double)this.a;
            if (x < 0)
            {
                Console.WriteLine("Нет корней !");
            }
             
                else return x;
            return -1;
        }
    }
    public override string ToString()
    {
        if (this.b > 0)
            return $"Линейное уравнение: {this.a} x + {this.b} = 0";
        else
            return $"Линейное уравнение: {this.a} x - {this.b * -1} = 0";
    }
}
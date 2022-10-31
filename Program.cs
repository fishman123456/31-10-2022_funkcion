// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

Kvadr df;
df = new Kvadr();
//Kvadr.dert("45+22+3=0");
Console.WriteLine(Kvadr.dert("4x+2=0"));



class Kvadr
    {
   private int a=0;
   private int b=0;
   private int myVar;

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

    public int MyProperty
	{
		get { return myVar; }
		set { myVar = value; }
	}


	public static  Kvadr dert(string var2)
	{
        Kvadr one = new Kvadr();
        string [] app = var2.Split('x', '+', '*', '=');
        one.A = Convert.ToInt32(app[0]);
        return one;
	}
    public override string ToString()
    {
        if (this.b > 0)
            return $"Линейное уравнение: {this.a} x + {this.b} = 0";
        else
            return $"Линейное уравнение: {this.a} x - {this.b * -1} = 0";
    }
}
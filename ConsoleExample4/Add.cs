using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleExample4
{
    class Add:JiSuan
    {
        string c;

public string C
{
  get { return c; }
  set { c = value; }
}
        string d;

public string D
{
  get { return d; }
  set { d = value; }
}
        
      //  public string C { get => c; set => c = value; }
       // public string D { get => d; set => d = value; }

        public override void GetNum()
        {
            Console.WriteLine(c+ d);
            Console.WriteLine(Num = A + B);
        }
    }
}

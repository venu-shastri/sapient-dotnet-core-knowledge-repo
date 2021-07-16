public class Program
{
//Compiler Generated
	class InnerClass{
	public int x;
	public int length;
		
	public bool ValidateString(string item){
		Console.WriteLine(this.x);
		return item.Length> this.length;
	  }
	}
	static Func<string,bool> CheckStringLengthGreaterThanGivenArgument_CompilerGenerated(int length)
        {
		InnerClass obj=new InnerClass();
		obj.x=100;
		Func<string,bool> _innerFunctionRef=new Func<string,bool>(obj.ValidateString);
		obj.x=500;
		return _innerFunctionRef;
        }
	
	
	static Func<string,bool> CheckStringLengthGreaterThanGivenArgument(int length)
        {
            int x = 100;
            Func<string,bool> _innerFunctionRef=(item)=>{ Console.WriteLine(x); return  item.Length > length;};
            x = 500;
            return _innerFunctionRef;
        }
	
	public static void Main()
	{
	Func<string,bool> _del=	CheckStringLengthGreaterThanGivenArgument(5);
		_del.Invoke("item");
_del=	CheckStringLengthGreaterThanGivenArgument_CompilerGenerated(5);
		_del.Invoke("newItem");
	}
}

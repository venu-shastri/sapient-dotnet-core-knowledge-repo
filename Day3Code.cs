class Employee{

	private string eid,name,dob;
	private decimal sal;
	
	public void Set_sal(decimal increment){
		this.sal+=increment;
	}
	public string Get_name(){
		return this.name;
	}
	//Property
	public string Eid{
	
	//Acessors (Mutators) - get ,set
	
	//Generates get Mutator - MSIL
	// public string get_Eid(){}
	get{
	
	     //Method Body
		 return this.eid;
	}
	
	}
}

Employee _employeeObj=new Employee();
string name=_employeeObj.Name;
_employeeObj.Set_sal(67777);
string eidValue=_employeeObj.Eid;//_employeeObj.get_Eid();



class CommonCodeForExceptionFamilyMembers{

    string stackTrace;
	string methodName;
	int lineNumber;
	string message;
	string remoteServerAddress;
}
class FileNotFoundException:CommonCodeForExceptionFamilyMembers{

	
	string fileName;
	string path;

}

class NullReferenceException:CommonCodeForExceptionFamilyMembers{
	
	object type;

}

class DBConnectionException:CommonCodeForExceptionFamilyMembers{
	string connectionString
	string timeOut;

}


//Default Interface : public members
//interface -> public view of an object
class List{
	
		public void Add(){}
		public void Remove(){}
		public void InsertAt(int index){}
		public void RemoveAt(int index){}
		public void Clear(){}
		...
		....
		.....
		......
}

class Stack{
  //has-a -> Delegation
  List _list=new List();
  public void Push(){ _list.Add();}
  public void Pop(){ _list.Remove();}
  public void Clear(){ _list.Clear();}
}

Stack obj=new Stack();
obj.Push();
obj.Pop();
obj.Clear();

//Composition
public class LoginWindow{

TextBox _userNameTextBox=new  TextBox();
TextBox _passwordTextBox=new  TextBox();


public void Dispose(){
	_userNameTextBox.Dispose();
	_passwordTextBox.Dispose()
}
}


publc class TextBox{

publc void Dispose(){}
}

public class Button(){

publc void Dispose(){}
}


publc class Label(){

publc void Dispose(){}
}

class Strudent{

string enrollmentNumber


}

class IDCard{

string enrollmentNumber;

}

Strudent _student1=new  Student("S100");

IDCard _idCard=new  IDCard(_student1.enrollmentNumber);

class Employee{

}


class Asset{

  string uniqueId;
}

//Association Uing ThridParty Class
class AssentUsage{

	string employeeId;
	string assetId
}



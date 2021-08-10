function test() {


}

test();//Default Binding call - context
test.apply("test value");//Explicit Binding

var obj = { funRef: test, x: 10, y: 30 } //Object Literal Syntax : var obj=new Object();
obj.funRef();//implicit Binding - test.apply(obj);

//new binding - function object -> Constructor 
// don;t return explicit value from the constructor (return this)
function Employee() {

    
}

new Employee();



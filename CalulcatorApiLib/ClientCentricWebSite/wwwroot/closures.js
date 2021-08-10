function test(x,y) {
    console.log(localVariable);//undefined
    var localVariable = "Hello";
//    var _this = this;
    
    
    //function inner () {
        
    //    localVariable += "Bye " + x;
    //    console.log(_this);//this->500
    //    console.log(localVariable); //"Hello Bye 100"
    //};

    //arrow functions
    var inner = () => {

        localVariable += "Bye " + x;
        console.log(this);//this->500
        console.log(localVariable); //"Hello Bye 100"

    };
    console.log(localVariable + "," + this);//Hello , this->500
    return inner;
}

var funRef1 = test.apply("this->500", [100,101]);
funRef1.apply("1"); 

var funRef2 = test.apply("this->600", [200,201]);

funRef2.apply("2");

funRef1.apply("3");
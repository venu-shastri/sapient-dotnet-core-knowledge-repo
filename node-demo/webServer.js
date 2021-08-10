// module loader 
const express = require('express')

function WebSever(port){

    this.app=undefined;
    this._port=port;
    
}

WebSever.prototype.initialize=function(){
    this.app=express();
    
}

WebSever.prototype. registerDefaultMiddleware=function(){
    this.app.get("/",(req,res)=>{ res.send("Hello From Express Server")});
}

WebSever.prototype.start=function(){
    this.app.listen(this._port,()=>{

        console.log(`WebServer Listening On ${this._port}`);
    });
}

module.exports=WebSever;
var redux=
(function()
{

    function Store(reducer,initialState){
        this._reducer=reducer;
        this._state=initialState;
        this._subscribers=[];
    }

    Store.prototype.getState=function(){ return this._state; };
    Store.prototype.dispatch=function(actionObj){ 
         this._state=this._reducer(actionObj,this._state);
        this._subscribers.forEach((subscriber)=>{

        subscriber();
        });
     };
    Store.prototype.subscribe=function(callback){
    this._subscribers.push(callback);
    }

return {
  
    createStore:function(reducer,initialState){

        return new Store(reducer,initialState);

    }
};

})();





import {dispatchInstance} from './dispatcher'

function ProductStore(dispatcher){

    this.products=[];
    dispatcher.register((action)=>{

            //Dispatcher - Callback 
            switch(action.name){
                case "ADD-NEW-PRODUCT":  this.addNewProduct(action.data);
                                        this.notifyViews();
                                         //Notify View

                                          break;
                default:break;
            }

    });

}

ProductStore.prototype.getState=function(){
    return this.products;
}

ProductStore.prototype.addNewProduct=function(product){
    this.products.push(product);
    
}
ProductStore.prototype.notifyViews=function(){

    this.trigger("listchanged");
}

export const productStoreInstance=new ProductStore(dispatchInstance);



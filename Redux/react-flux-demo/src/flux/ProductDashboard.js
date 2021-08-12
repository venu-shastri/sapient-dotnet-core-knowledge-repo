import React from "react";
import { act } from "react-dom/cjs/react-dom-test-utils.production.min";
import {NewProduct} from './NewProduct'
import { ProductList } from "./ProductList";
export class ProductDashBoard extends React.Component{

    constructor(props){
        super(props);
        this.onNewProduct=this.onNewProduct.bind(this);
    }
    onNewProduct(product){

        console.log(product);
        const action={name:"ADD-NEW-PRODUCT",data:product};
        this.props.dispatcher.dispatch(action);

    }
    componentDidMount(){
        this.props.store.bind("listchanged",()=>{

            const products=this.props.store.getState();
            console.log(products);

        });
    }
    render(){
        return(
            <div>
            <p>Product ProductDashBoard Works!</p>
            <NewProduct onNewProductAvailableCallback={this.onNewProduct}></NewProduct>
           <ProductList products={????}></ProductList>
            </div>
        )
    }
}
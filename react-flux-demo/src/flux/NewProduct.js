import React from "react";

export class NewProduct extends React.Component{

    constructor(props){
        super(props);
        this.onNewProductClick=this.onNewProductClick.bind(this);
    }
    onNewProductClick(){
        let product={Id:Math.random(),Name:`P${Math.random()}`,Price:Math.random()}
        this.props.onNewProductAvailableCallback(product);
    }

    render(){
        return(
            <React.Fragment>
            <p>NewProduct Works!</p>
            <button onClick={this.onNewProductClick}>New Product</button>
            </React.Fragment>
        )
    }
}
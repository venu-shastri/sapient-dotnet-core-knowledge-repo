import React from "react";
import { ProductRow } from "./ProductRow";
export class ProductList extends React.Component{

    render(){

        productRows=[];
        for(let i=0;i<this.props.products){

            productRows.push(<ProductRow product={this.props.products[i]} key={this.props.products[i].Id}></ProductRow>)

        }
        return(
            <div>
            <p>Product List Works!</p>
            <table>
                <tbody>
                    {productRows}
                </tbody>
            </table>
            </div>
        )
    }
}
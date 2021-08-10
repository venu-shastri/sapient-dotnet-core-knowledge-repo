import { ProductRow } from "./ProductRow";

export function ProductTable(props){

    let productRowComponentArray=[];
    let _products=props.products;
    _products.forEach(product => {
        
        productRowComponentArray.push(<ProductRow product={product} key={product.Id}/>);
    });

return(

    <table>
        <thead>
        <tr>
            <th>Product Id</th>
            <th>Product Name</th>
            <th>Product Price</th>
        </tr>
        </thead>
        <tbody>
            {productRowComponentArray}
        </tbody>

        
    </table>
);

}
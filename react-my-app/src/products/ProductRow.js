export function ProductRow(props){

    return(
        <tr>
            <td>{props.product.Id}</td>
            <td>{props.product.Name}</td>
            <td>{props.product.Price}</td>
        </tr>
    )
}
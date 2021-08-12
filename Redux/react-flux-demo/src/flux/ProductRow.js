import React from 'react'

export function ProductRow(product){

    return(
        <tr>
            <td>{product.Id}</td>
            <td>{product.Name}</td>
            <td>
               <input type="text" value={product.Price}/>
            </td>
            <td>
                <button>update</button>
            </td>
        </tr>
    )
}
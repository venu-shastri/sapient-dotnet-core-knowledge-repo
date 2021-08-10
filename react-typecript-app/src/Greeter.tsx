import React from 'react'
import { IGreeterProps } from './IGreeterProps';
// export const Greeter:React.FunctionComponent<IGreeterProps>=(props:IGreeterProps)=>{
//     return(
//         //jsx
//    <h1>{props.message}</h1>
//     );
// }


// export const Greeter:React.FunctionComponent<IGreeterProps>=function(props:IGreeterProps){
//     return(
//         //jsx
//    <h1>{props.message}</h1>
//     );
// }

export function Greeter(props:IGreeterProps){
    return (
            <h1>{props.message}</h1>
    );
}
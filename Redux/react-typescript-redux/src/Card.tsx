import React from "react";

type Props={card:ICard};

export const Card:React.FC<Props>=(({card})=>{

    return(
        <div>
            <h1>{card.cardNumber}</h1>
            <p>{card.holderName}</p>
            <p>{card.cvv}</p>
            <p>{card.expireDate}</p>
        </div>
    )
});
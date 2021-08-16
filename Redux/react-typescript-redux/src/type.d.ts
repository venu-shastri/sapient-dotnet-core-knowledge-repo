interface ICard{
    cardNumber:string;
    holderName:string;
    cvv:number;
    expireDate:string;

}

//state
type CardsState={cards:ICard[]};

//Action Type
type CardAction={type:string,data:ICard}


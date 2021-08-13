interface ICard{
    cardNumber:string;
    holderName:string;
    cvv:number;
    expireDate:string;

}

type CardsState={cards:ICard[]};

type CardAction={type:string,data:ICard}


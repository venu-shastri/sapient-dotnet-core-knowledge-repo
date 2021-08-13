import React  from "react";

type props={
    saveCard:(card:ICard | any)=>void
}

export const AddCard:React.FC<props>=({saveCard})=>{

    const[card,setCard]=React.useState<ICard |{}>();
    const handleCardData=(e:React.FormEvent<HTMLInputElement>)=>{
        setCard ({...card,[e.currentTarget.id]:e.currentTarget.value})
    }
    const addNewCard=(e:React.FormEvent)=>{
        e.preventDefault();
        saveCard(card);
    }

    return(
        <form onSubmit={addNewCard}>
            <input type="text"
             id="cardNumber"
              placeholder="Card Number" 
              onChange={handleCardData}/>

            <input type="text"
             id="holderNane"
              placeholder="Card Holder Name" 
              onChange={handleCardData}/>

            <input type="text"
             id="cvv"
              placeholder="cvv" 
              onChange={handleCardData}/>
               <input type="text"
             id="expireDate"
              placeholder="Expire State" 
              onChange={handleCardData}/>
            <button disabled={card===undefined?true:false}>Add Card</button>

        </form>
    )

};
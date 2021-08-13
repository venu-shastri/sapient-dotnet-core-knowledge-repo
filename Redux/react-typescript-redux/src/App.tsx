import React from 'react';
import {useSelector,useDispatch,shallowEqual} from 'react-redux'
import { addCard } from './actions/creators';
import { AddCard } from './AddCard';
import './App.css';
import { Card } from './Card';

const App:React.FC=()=>{

  const cards: readonly ICard[]=useSelector((state:CardsState)=>state.cards,shallowEqual);
  const dispatch=useDispatch();
  const saveCard=React.useCallback((card:ICard)=>dispatch(addCard(card)),[dispatch]);



return(
  <main>
    <AddCard saveCard={saveCard}></AddCard>
    {cards.map((c:ICard)=>(

      <Card card={c} key={c.cardNumber}></Card>
    ))}
  
     
  </main>
);
}
export default App;

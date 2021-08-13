import * as constants from '../actions/constants'
const initialState:CardsState={
    cards:[
        {cardNumber:"123456",holderName:"Kini",cvv:123,expireDate:"5/2030"},
        {cardNumber:"123436",holderName:"James",cvv:132,expireDate:"5/2031"},
        {cardNumber:"123256",holderName:"Jack",cvv:323,expireDate:"5/2032"},
        {cardNumber:"122456",holderName:"Hary",cvv:111,expireDate:"5/2033"},
    ]
};

export const reducer=(state:CardsState=initialState,action:CardAction)=>{

    switch(action.type){
        case constants.ADD_CARD:
           return {...state,cards:state.cards.concat(action.data)};    
        
        default: break;
    }
    return state;
}
import * as constants from './constants'

export function addCard(card:ICard){
    const action:CardAction={
        type:constants.ADD_CARD,
        data:card
    };
    return action;
}
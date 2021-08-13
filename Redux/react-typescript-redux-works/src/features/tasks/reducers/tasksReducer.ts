import * as ActionTypes from '../constants/actionTypes'
const  initialState={
    tasks:[
        {id:1,title:"Task1",description:"Task1 Description"},
        {id:2,title:"Task2",description:"Task2 Description"},
    ],
    users:[],
    projects:[]
};

export const tasksReducer=(state:any=initialState,action:any)=>{

    switch(action.type){
        case ActionTypes.ADD_TASK :
        return {...state, tasks:state.tasks.concat(action.data)};    
        
    }
    return state;
}



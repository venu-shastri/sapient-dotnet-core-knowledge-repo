import * as ActionTypes from '../constants/actionTypes'

export function getAddNewTaskAction(task:any){

    const action={type:ActionTypes.ADD_TASK,data:task};
    return action;
}
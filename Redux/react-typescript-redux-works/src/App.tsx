import React from 'react';
import {connect} from 'react-redux'
import './App.css';
import {AddTask} from './features/tasks/components/AddTask'
import {Task} from './features/tasks/components/Task'
import * as taskActionCreators from './features/tasks/actions/taskActionCreators'
function App(props:any) {
  return (
    <div className="App">
    <p>App Works</p>
    <AddTask onSaveTask={(task:any)=>{
      props.dispatch(taskActionCreators.getAddNewTaskAction(task))
    }}></AddTask>

    {
      props.tasksProp.map((task:any)=>(
        <Task task={task} key={task.id}/>
      ))
    }
    </div>
  );
}

//Selector
function mapStateToProps(stateFromStore:any) {
  return {
    tasksProp: stateFromStore.tasks,
  };
}

export const AppWrapper=connect(mapStateToProps)(App);

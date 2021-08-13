import React from 'react'


export function AddTask(props:any){

    
    const addTask=(e:React.FormEvent)=>{
        e.preventDefault();
        props.onSaveTask({id:Math.floor(Math.random() * 100) + 1,title:"Title",description:'Test Description'});

    }
    return(
        
        <form onSubmit={addTask}>
                <button>AddNewTask</button>
        </form>
    )
}


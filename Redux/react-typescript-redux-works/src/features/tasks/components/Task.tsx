import React from 'react'

export function Task(props:any){

    return(
        <div>
            <h1>{props.task.id}</h1>
            <h5>{props.task.title}</h5>
            <h6>{props.task.description}</h6>
        </div>
    )
}
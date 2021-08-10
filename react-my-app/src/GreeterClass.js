import React from 'react'
export class GreeterClass extends React.Component {

    render(){
        return(<h1>{this.props.message}</h1>);
    }
}